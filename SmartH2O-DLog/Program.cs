using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace SmartH2O_DLog
{
    class Program
    {
        

        private static MqttClient m_cClient;

        static void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            /*
            Console.WriteLine("Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " + e.Topic);
            */
            string filePathParams = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"App_Data\param-data.xml";
            string filePathAlarms = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"App_Data\alarms-data.xml";
            if (e.Topic == "PH" || e.Topic == "NH3" || e.Topic == "CI2")
            {
                //ESCREVER NO FICHEIRO PARAM-DATA
                XmlDocument doc = new XmlDocument();
                doc.Load(filePathParams);
                XmlNode root = doc.GetElementsByTagName("quality-parameters")[0];

                String newSensor = Encoding.UTF8.GetString(e.Message);
                XmlDocument docAux = new XmlDocument();
                docAux.LoadXml(newSensor);
                XmlNode qualityParameter = docAux.GetElementsByTagName("quality-parameter")[0];
                XmlNode name = qualityParameter.SelectSingleNode("/quality-parameter/name");
                XmlNode value = qualityParameter.SelectSingleNode("/quality-parameter/value");
                XmlNode date = qualityParameter.SelectSingleNode("/quality-parameter/date");

                XmlElement nameP = doc.CreateElement(name.InnerText);
                nameP.AppendChild(nameP.OwnerDocument.ImportNode(value, true));
                nameP.AppendChild(nameP.OwnerDocument.ImportNode(date, true));

                

                root.AppendChild(root.OwnerDocument.ImportNode(nameP, true));
                doc.Save(filePathParams);
                Console.WriteLine("Adicionei parametro ao ficheiro param_data.xml!");
            } else if (e.Topic == "alarm")
            {
                //ESCREVER NO FICHEIRO DOS ALARMS-DATA
                XmlDocument doc = new XmlDocument();
                doc.Load(filePathAlarms);
                XmlNode root = doc.GetElementsByTagName("alarms")[0];

                String newAlarm = Encoding.UTF8.GetString(e.Message);
                XmlDocument docAux = new XmlDocument();
                docAux.LoadXml(newAlarm);
                XmlNode alarm = docAux.GetElementsByTagName("quality-parameter")[0];
                XmlNode name = alarm.SelectSingleNode("/quality-parameter/name");
                XmlNode value = alarm.SelectSingleNode("/quality-parameter/value");
                XmlNode date = alarm.SelectSingleNode("/quality-parameter/date");
                XmlNode rule = alarm.SelectSingleNode("/quality-parameter/rule");

                XmlElement nameP = doc.CreateElement(name.InnerText);
                nameP.AppendChild(nameP.OwnerDocument.ImportNode(value, true));
                nameP.AppendChild(nameP.OwnerDocument.ImportNode(date, true));
                nameP.AppendChild(nameP.OwnerDocument.ImportNode(rule, true));

                root.AppendChild(root.OwnerDocument.ImportNode(nameP, true));
                doc.Save(filePathParams);
                Console.WriteLine("Adicionei alarme ao ficheiro alarms-data.xml!");
            }
            

        }

        static void Main(string[] args)
        {
            m_cClient = new MqttClient(IPAddress.Parse("127.0.0.1"));
            string[] m_strTopicsInfo = { "PH", "NH3", "CI2", "alarm" };
            m_cClient.Connect(Guid.NewGuid().ToString());
            if (!m_cClient.IsConnected)
            {
                Console.WriteLine("Error connecting to message broker...");
                return;
            }
            //Specify events we are interest on
            //New Msg Arrived
            m_cClient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            //Subscribe to topics
            byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };//QoS
            m_cClient.Subscribe(m_strTopicsInfo, qosLevels);

            Console.ReadKey();
            if (m_cClient.IsConnected)
            {
                m_cClient.Unsubscribe(m_strTopicsInfo); //Put this in a button to see notif!
                m_cClient.Disconnect(); //Free process and process's resources
            }
        }
    }
}
