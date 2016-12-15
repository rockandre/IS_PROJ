using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        MqttClient m_cClient = new MqttClient(IPAddress.Parse("127.0.0.1"));
        string[] m_strTopicsInfo = {"PH", "NH3", "CI2", "ALARM" };

        public SmartH2O_Alarm()
        {
            InitializeComponent();
            InitializeTriggerRules();
            m_cClient.Connect(Guid.NewGuid().ToString());
            MessageBox.Show("Hello");
            if (!m_cClient.IsConnected)
            {
                MessageBox.Show("Error connecting to message broker...");
                return;
            }
        }

        private void InitializeTriggerRules()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(dec);

            XmlElement sensors = doc.CreateElement("sensors");
            XmlElement ph = doc.CreateElement("ph");
            XmlElement conditions = doc.CreateElement("conditions");
            conditions.SetAttribute("ative", "");
            XmlElement condition = doc.CreateElement("condition");
            condition.SetAttribute("ative", "");
            condition.SetAttribute("operator", "");
            condition.SetAttribute("value", "");
            conditions.AppendChild(condition);
            ph.AppendChild(conditions);
            sensors.AppendChild(ph);
            doc.AppendChild(sensors);
            doc.Save("C:/Users/rockandre/Documents/Visual Studio 2015/Projects/SmartH2O/SmartH2O_Alarm/trigger-rules.xml");
        }

        private void SmartH2OAlarm_Load(object sender, EventArgs e)
        {
            
        }

        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            MessageBox.Show("Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " +
            e.Topic);

            checkValues(e.Message);
        }

        private void checkValues(byte[] message)
        {
            XmlDocument doc = new XmlDocument();
            String xml = Encoding.UTF8.GetString(message);
            doc.LoadXml(xml);
            Console.WriteLine(doc.OuterXml);
            XmlNode nome = doc.SelectSingleNode("/sensor/name");
            /*if (nome.InnerText == "PH")
            {
                Console.WriteLine("É PH! \n");
                m_cClient.Publish("PH", Encoding.UTF8.GetBytes(doc.OuterXml));
            }
            if (nome.InnerText == "NH3")
            {
                Console.WriteLine("É NH3! \n");
                m_cClient.Publish("NH3", Encoding.UTF8.GetBytes(doc.OuterXml));
            }
            if (nome.InnerText == "CI2")
            {
                Console.WriteLine("É CI2! \n");
                m_cClient.Publish("CI2", Encoding.UTF8.GetBytes(doc.OuterXml));
            }*/
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Specify events we are interest on
            //New Msg Arrived
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
            m_cClient.Unsubscribe(m_strTopicsInfo);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
