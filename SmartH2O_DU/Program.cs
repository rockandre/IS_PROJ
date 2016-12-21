using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorNodeDll;
using System.Xml;
using uPLibrary.Networking.M2Mqtt;
using System.Net;

namespace SmartH2O_DU
{
    class Program
    {
        private String ph;

        static void Main(string[] args)
        {
            SensorNodeDll.SensorNodeDll sensorNodeDll = new SensorNodeDll.SensorNodeDll();
            sensorNodeDll.Initialize(newValueIncoming, 1000);
        }

        private static void newValueIncoming(string message)
        {
            Console.WriteLine(message);

            String[] substrings = message.Split(';');
            XmlDocument doc = new XmlDocument();
            
            DateTime dateNow = DateTime.Now;

            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(dec);

            XmlElement root = doc.CreateElement("quality-parameter");
            doc.AppendChild(root);

            XmlElement id = doc.CreateElement("id");
            id.InnerText = substrings[0];
            XmlElement name = doc.CreateElement("name");
            name.InnerText = substrings[1];
            XmlElement value = doc.CreateElement("value");
            value.InnerText = substrings[2];
            XmlElement date = doc.CreateElement("date");
            date.InnerText = dateNow.ToString("d/MM/yyyy HH:mm:ss");

            root.AppendChild(id);
            root.AppendChild(name);
            root.AppendChild(value);
            root.AppendChild(date);

            Console.WriteLine(doc.OuterXml);
            
            MqttClient m_cClient = new MqttClient(IPAddress.Parse("127.0.0.1"));
            m_cClient.Connect(Guid.NewGuid().ToString());
            if (!m_cClient.IsConnected)
            {
                Console.WriteLine("Error connecting to message broker...");
                return;
            }
            m_cClient.Publish("sensor", Encoding.UTF8.GetBytes(doc.OuterXml));
        }

        
    }
}

