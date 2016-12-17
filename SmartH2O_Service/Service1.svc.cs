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
        string FILEPATH = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"App_Data\bookstore.xml";

        public List<QualityParameters> GetDataByDay(string parameter)
        {
            List<QualityParameters> lista = new List<QualityParameters>();

            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);

            XmlNodeList parameters = doc.SelectNodes("/quality-parameters/"+parameter+"/value");
            foreach (XmlNode item in parameters)
            {
                
            }

            return lista;
        }



    }
}
