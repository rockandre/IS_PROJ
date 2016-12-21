using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace SmartH2O_Alarm
{
    public partial class SmartH2O_Alarm : Form
    {
        public static string TRIGGER_RULES = @"C:\SmartH2O_Data\SmartH2O_Alarm\trigger-rules.xml";
        private static MqttClient m_cClient = new MqttClient(IPAddress.Parse("127.0.0.1"));
        string[] m_strTopicsInfo = {"PH", "NH3", "CI2", "alarm" };
        string[] sensorsInfo;
        XmlDocument trigger_rules = new XmlDocument();

        public SmartH2O_Alarm()
        {
            InitializeComponent();
            m_cClient.Connect(Guid.NewGuid().ToString());
            if (!m_cClient.IsConnected)
            {
                MessageBox.Show("Error connecting to message broker...");
                return;
            }
        }

        private void ReadFromXml()
        {
            if (File.Exists(TRIGGER_RULES))
            {
                trigger_rules.Load(TRIGGER_RULES);
            } else
            {
                CreateTriggerRules();
            }
        }

        private void CreateTriggerRules()
        {
            XmlDeclaration dec = trigger_rules.CreateXmlDeclaration("1.0", "UTF-8", null);
            trigger_rules.AppendChild(dec);
            XmlComment comment = trigger_rules.CreateComment("Para inserir um intervalo de valores utilize o seguinte metodo (valor_menor;valor_maior)");
            trigger_rules.AppendChild(comment);

            XmlElement sensors = trigger_rules.CreateElement("sensors");
            XmlElement sensorPH = trigger_rules.CreateElement("sensor");
            sensorPH.SetAttribute("type", "PH");
            XmlElement sensorCI2 = trigger_rules.CreateElement("sensor");
            sensorCI2.SetAttribute("type", "CI2");
            XmlElement sensorNH3 = trigger_rules.CreateElement("sensor");
            sensorNH3.SetAttribute("type", "NH3");
            XmlElement conditionsPH = trigger_rules.CreateElement("conditions");
            XmlElement conditionsCI2 = trigger_rules.CreateElement("conditions");
            XmlElement conditionsNH3 = trigger_rules.CreateElement("conditions");
            conditionsPH.SetAttribute("ative", "true");
            conditionsCI2.SetAttribute("ative", "true");
            conditionsNH3.SetAttribute("ative", "true");
            XmlElement conditionPH = trigger_rules.CreateElement("condition");
            XmlElement conditionCI2 = trigger_rules.CreateElement("condition");
            XmlElement conditionNH3 = trigger_rules.CreateElement("condition");
            conditionPH.SetAttribute("ative", "true");
            conditionCI2.SetAttribute("ative", "true");
            conditionNH3.SetAttribute("ative", "true");
            conditionPH.SetAttribute("operator", "equal");
            conditionCI2.SetAttribute("operator", "less_than");
            conditionNH3.SetAttribute("operator", "between");
            conditionPH.SetAttribute("value", "6");
            conditionCI2.SetAttribute("value", "3.5");
            conditionNH3.SetAttribute("value", "1.4;2.3");
            conditionsPH.AppendChild(conditionPH);
            conditionsCI2.AppendChild(conditionCI2);
            conditionsNH3.AppendChild(conditionNH3);
            sensorPH.AppendChild(conditionsPH);
            sensorCI2.AppendChild(conditionsCI2);
            sensorNH3.AppendChild(conditionsNH3);
            sensors.AppendChild(sensorPH);
            sensors.AppendChild(sensorCI2);
            sensors.AppendChild(sensorNH3);
            trigger_rules.AppendChild(sensors);
            trigger_rules.Save(TRIGGER_RULES);
        }

        private void SmartH2OAlarm_Load(object sender, EventArgs e)
        {
            
        }

        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
           /* MessageBox.Show("Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " +
            e.Topic);*/
            if (e.Topic != "alarm")
            {
                checkValues(e.Message);
            }
        }

        private void checkValues(byte[] message)
        {
            XmlDocument infoReceived = new XmlDocument();
            String xml = Encoding.UTF8.GetString(message);
            infoReceived.LoadXml(xml);
            
            XmlNode qualityParameter = infoReceived.SelectSingleNode("/quality-parameter");

            switch (qualityParameter["name"].InnerText)
            {
                case "PH":
                    XmlNodeList rulesPH = trigger_rules.SelectNodes("/sensors/sensor[@type='PH']/conditions/condition");

                    if (trigger_rules.SelectSingleNode("/sensors/sensor[@type='PH']/conditions").Attributes["ative"].InnerText == "true")
                    {
                        foreach (XmlNode rule in rulesPH)
                        {
                            if (rule.Attributes["ative"].InnerText == "true")
                            {
                                switch (rule.Attributes["operator"].InnerText)
                                {
                                    case "equal":
                                        try
                                        {
                                            if (float.Parse(qualityParameter["value"].InnerText.Replace('.', ',')) != float.Parse(rule.Attributes["value"].InnerText.Replace('.', ',')))
                                            {
                                                writeTochannel(rule, qualityParameter);
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            MessageBox.Show("Error: " + e.Message);
                                        }
                                        break;
                                    case "less_than":
                                        try
                                        {
                                            if (float.Parse(qualityParameter["value"].InnerText.Replace('.', ',')) >= float.Parse(rule.Attributes["value"].InnerText.Replace('.', ',')))
                                            {
                                                writeTochannel(rule, qualityParameter);
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            MessageBox.Show("Error: " + e.Message);
                                        }
                                        break;
                                    case "greater_than":
                                        try
                                        {
                                            if (float.Parse(qualityParameter["value"].InnerText.Replace('.', ',')) <= float.Parse(rule.Attributes["value"].InnerText.Replace('.', ',')))
                                            {
                                                writeTochannel(rule, qualityParameter);
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            MessageBox.Show("Error: " + e.Message);
                                        }
                                        break;
                                    case "between":
                                        try
                                        {
                                            string[] values = rule.Attributes["value"].InnerText.Split(';');
                                            if (float.Parse(qualityParameter["value"].InnerText.Replace('.', ',')) < float.Parse(values[0].Replace('.', ','))
                                                || float.Parse(qualityParameter["value"].InnerText.Replace('.', ',')) > float.Parse(values[1].Replace('.', ',')))
                                            {
                                                writeTochannel(rule, qualityParameter);
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            MessageBox.Show("Error: " + e.Message);
                                        }
                                        break;
                                }
                            }
                        }
                    }
                    break;
                case "CI2":
                    XmlNodeList rulesCI2 = trigger_rules.SelectNodes("/sensors/sensor[@type='CI2']/conditions/condition");

                    if (trigger_rules.SelectSingleNode("/sensors/sensor[@type='CI2']/conditions").Attributes["ative"].InnerText == "true")
                    {
                        foreach (XmlNode rule in rulesCI2)
                        {
                            if (rule.Attributes["ative"].InnerText == "true")
                            {
                                switch (rule.Attributes["operator"].InnerText)
                                {
                                    case "equal":
                                        try
                                        {
                                            if (float.Parse(qualityParameter["value"].InnerText.Replace('.', ',')) != float.Parse(rule.Attributes["value"].InnerText.Replace('.', ',')))
                                            {
                                                writeTochannel(rule, qualityParameter);
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            MessageBox.Show("Error: " + e.Message);
                                        }
                                        break;
                                    case "less_than":
                                        try
                                        {
                                            if (float.Parse(qualityParameter["value"].InnerText.Replace('.', ',')) >= float.Parse(rule.Attributes["value"].InnerText.Replace('.', ',')))
                                            {
                                                writeTochannel(rule, qualityParameter);
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            MessageBox.Show("Error: " + e.Message);
                                        }
                                        break;
                                    case "greater_than":
                                        try
                                        {
                                            if (float.Parse(qualityParameter["value"].InnerText.Replace('.', ',')) <= float.Parse(rule.Attributes["value"].InnerText.Replace('.', ',')))
                                            {
                                                writeTochannel(rule, qualityParameter);
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            MessageBox.Show("Error: " + e.Message);
                                        }
                                        break;
                                    case "between":
                                        try
                                        {
                                            string[] values = rule.Attributes["value"].InnerText.Split(';');
                                            if (float.Parse(qualityParameter["value"].InnerText.Replace('.', ',')) < float.Parse(values[0].Replace('.', ','))
                                                || float.Parse(qualityParameter["value"].InnerText.Replace('.', ',')) > float.Parse(values[1].Replace('.', ',')))
                                            {
                                                writeTochannel(rule, qualityParameter);
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            MessageBox.Show("Error: " + e.Message);
                                        }
                                        break;
                                }
                            }
                        }
                    }
                    break;
                case "NH3":
                    XmlNodeList rulesNH3 = trigger_rules.SelectNodes("/sensors/sensor[@type='NH3']/conditions/condition");

                    if (trigger_rules.SelectSingleNode("/sensors/sensor[@type='NH3']/conditions").Attributes["ative"].InnerText == "true")
                    {
                        foreach (XmlNode rule in rulesNH3)
                        {
                            if (rule.Attributes["ative"].InnerText == "true")
                            {
                                switch (rule.Attributes["operator"].InnerText)
                                {
                                    case "equal":
                                        try
                                        {
                                            if (float.Parse(qualityParameter["value"].InnerText.Replace('.', ',')) != float.Parse(rule.Attributes["value"].InnerText.Replace('.', ',')))
                                            {
                                                writeTochannel(rule, qualityParameter);
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            MessageBox.Show("Error: " + e.Message);
                                        }
                                        break;
                                    case "less_than":
                                        try
                                        {
                                            if (float.Parse(qualityParameter["value"].InnerText.Replace('.', ',')) >= float.Parse(rule.Attributes["value"].InnerText.Replace('.', ',')))
                                            {
                                                writeTochannel(rule, qualityParameter);
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            MessageBox.Show("Error: " + e.Message);
                                        }
                                        break;
                                    case "greater_than":
                                        try
                                        {
                                            if (float.Parse(qualityParameter["value"].InnerText.Replace('.', ',')) <= float.Parse(rule.Attributes["value"].InnerText.Replace('.', ',')))
                                            {
                                                writeTochannel(rule, qualityParameter);
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            MessageBox.Show("Error: " + e.Message);
                                        }
                                        break;
                                    case "between":
                                        try
                                        {
                                            string[] values = rule.Attributes["value"].InnerText.Split(';');
                                            if (float.Parse(qualityParameter["value"].InnerText.Replace('.', ',')) < float.Parse(values[0].Replace('.', ','))
                                                || float.Parse(qualityParameter["value"].InnerText.Replace('.', ',')) > float.Parse(values[1].Replace('.', ',')))
                                            {
                                                writeTochannel(rule, qualityParameter);
                                            }
                                        }
                                        catch (Exception e)
                                        {
                                            MessageBox.Show("Error: " + e.Message);
                                        }
                                        break;
                                }
                            }
                        }
                    }
                    break;
            }
        }

        private static void writeTochannel(XmlNode rule, XmlNode qualityParameter)
        {
            XmlDocument alarmXml = new XmlDocument();
            XmlDeclaration dec = alarmXml.CreateXmlDeclaration("1.0", "UTF-8", null);
            alarmXml.AppendChild(dec);
            XmlElement qualParameter = alarmXml.CreateElement("quality-parameter");
            XmlElement name = alarmXml.CreateElement("name");
            name.InnerText = qualityParameter["name"].InnerText;
            XmlElement value = alarmXml.CreateElement("value");
            value.InnerText = qualityParameter["value"].InnerText;
            XmlElement date = alarmXml.CreateElement("date");
            date.InnerText = qualityParameter["date"].InnerText;
            XmlElement ruleFailed = alarmXml.CreateElement("rule");
            XmlElement ruleOperator = alarmXml.CreateElement("operator");
            ruleOperator.InnerText = rule.Attributes["operator"].InnerText;
            XmlElement ruleValue = alarmXml.CreateElement("value");
            ruleValue.InnerText = rule.Attributes["value"].InnerText;
            ruleFailed.AppendChild(ruleOperator);
            ruleFailed.AppendChild(ruleValue);
            qualParameter.AppendChild(name);
            qualParameter.AppendChild(value);
            qualParameter.AppendChild(date);
            qualParameter.AppendChild(ruleFailed);
            alarmXml.AppendChild(qualParameter);

            m_cClient.Publish("alarm", Encoding.UTF8.GetBytes(alarmXml.OuterXml));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ReadFromXml();
            //Specify events we are interest on
            //New Msg Arrived
            labelAlarme.Text = "Alarme Ligado";
            m_cClient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            //This client's subscription operation id done
            //m_cClient.MqttMsgSubscribed += client_MqttMsgSubscribed;
            //This client's unsubscription operation is done
            //m_cClient.MqttMsgUnsubscribed += client_MqttMsgUnsubscribed;
            //Subscribe to topics
            byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };//QoS
            m_cClient.Subscribe(m_strTopicsInfo, qosLevels);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            labelAlarme.Text = "Alarme Desligado";
            m_cClient.Unsubscribe(m_strTopicsInfo);

            if (m_cClient.IsConnected)
            {
                m_cClient.Unsubscribe(m_strTopicsInfo); //Put this in a button to see notif!
                m_cClient.Disconnect(); //Free process and process's resources
            }
        }
    }
}
