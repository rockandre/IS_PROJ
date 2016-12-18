using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace SmartH2O_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        string FILEPATH = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"App_Data\param-data.xml";


        public List<string> getInfoByParameter(string parameter)
        {
            List<string> lista = new List<string>();
            string finalString = "";
          
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);
            
            XmlNodeList parameters = doc.SelectNodes("/quality-parameters/parameter[@value = parameter]");

            
            finalString = finalString + parameter;
            
            foreach (XmlNode itemValues in parameters)
            {
                XmlNodeList values = doc.SelectNodes("/quality-parameters/" + parameter+"/value");
                finalString = finalString + "   Value: ";
                foreach (XmlNode item in values)
                {
                    finalString = finalString + item.InnerText;
                }

                XmlNodeList dates = doc.SelectNodes("/quality-parameters/" + parameter + "/date");
                finalString = finalString + "   Date: ";
                foreach (XmlNode item1 in dates)
                {
                    finalString = finalString + item1.InnerText;
                }

                lista.Add(finalString);
            }


            return lista;
        }

        public HashSet<string> GetDates()
        {
            HashSet<string> lista = new HashSet<string>();
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);

            XmlNodeList nos = doc.SelectNodes("/quality-parameters/*/date");
            foreach (XmlNode item in nos)
            {
                int space = item.InnerText.IndexOf(" ");
                if (lista.Add(item.InnerText.Substring(0, space)) != false)
                {
                    lista.Add(item.InnerText.Substring(0, space));
                }
            }

            return lista;
        }


        public List<string> getAlarmInfoTwoDates(string date1, string date2)
        {
            List<string> lista = new List<string>();


            return lista;
        }


    }
}
