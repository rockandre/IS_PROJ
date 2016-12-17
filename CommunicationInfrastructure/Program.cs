using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace CommunicationInfrastructure
{
    class Program
    {
        private static MqttClient m_cClient;

        static void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            //Recebeu mensagem
            if(e.Topic == "sensor")
            {
                publishParameterReceived(e.Message);
            }
            if(e.Topic == "alarm")
            {
                Console.WriteLine(" ************************************************* ");
                Console.WriteLine("           UM ALARME FOI ATIVADO!!" );
                Console.WriteLine(" ************************************************* ");

                /* Alarme tem de ser publicado assim:
                   <quality-parameter>
	                    <name> </name>
	                    <value> </value>
	                    <date> </date>
	                    <rule> </rule>
                    </quality-parameter>
                */
            }
            

        }

        private static void publishParameterReceived(byte[] message)
        {
            //Recebeu um novo parametro
            XmlDocument doc = new XmlDocument();
            String xml = Encoding.UTF8.GetString(message);
            doc.LoadXml(xml);
            Console.WriteLine("     *****RECEBI UM NOVO PARAMETRO!*****");
            XmlNode nome = doc.SelectSingleNode("/quality-parameter/name");
            if (nome.InnerText == "PH")
            {
                m_cClient.Publish("PH", Encoding.UTF8.GetBytes(doc.OuterXml));
                Console.WriteLine("PUBLIQUEI NO CANAL: PH! \n");
            }
            if (nome.InnerText == "NH3")
            {
                
                m_cClient.Publish("NH3", Encoding.UTF8.GetBytes(doc.OuterXml));
                Console.WriteLine("PUBLIQUEI NO CANAL: NH3! \n");
            }
            if (nome.InnerText == "CI2")
            {
                m_cClient.Publish("CI2", Encoding.UTF8.GetBytes(doc.OuterXml));
                Console.WriteLine("PUBLIQUEI NO CANAL: CI2! \n");
            }
        }

        static void Main(string[] args)
        {
            m_cClient = new MqttClient(IPAddress.Parse("127.0.0.1"));
            string[] m_strTopicsInfo = { "sensor", "alarm"};
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
            byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };//QoS
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
