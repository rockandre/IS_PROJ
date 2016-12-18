using SmartH2O_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using System.Web;
using System.Xml;

namespace SmartH2O_Service.Controllers
{
    public class ParametersController : ApiController
    {

        string FILEPATH = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, @"App_Data\param-data.xml");
        

        [Route("parameters")]
        public List<Parameter> GetAllParameters()
        {
            List<Parameter> lista = new List<Parameter>();
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);

            XmlNodeList parametersPH = doc.SelectNodes("quality-parameters/PH");
            foreach (XmlNode item in parametersPH)
            {
                string value = item.SelectSingleNode("value").InnerText;
                string date = item.SelectSingleNode("date").InnerText;

                lista.Add(new Parameter { Name = "PH", Value = value, Date = date });
            }
            XmlNodeList parametersNH3 = doc.SelectNodes("quality-parameters/NH3");
            foreach (XmlNode item in parametersNH3)
            {
                string value = item.SelectSingleNode("value").InnerText;
                string date = item.SelectSingleNode("date").InnerText;

                lista.Add(new Parameter { Name = "NH3", Value = value, Date = date });
            }
            XmlNodeList parametersCI2 = doc.SelectNodes("quality-parameters/CI2");
            foreach (XmlNode item in parametersCI2)
            {
                string value = item.SelectSingleNode("value").InnerText;
                string date = item.SelectSingleNode("date").InnerText;

                lista.Add(new Parameter { Name = "CI2", Value = value, Date = date });
            }

            return lista;
        }

        [Route("parameters/{name}")]
        public IHttpActionResult GetParametersByName(string name)
        {
            name = name.ToUpper();
            if (name == "PH" || name == "CI2" || name == "NH3")
            {
                List<Parameter> lista = new List<Parameter>();
                XmlDocument doc = new XmlDocument();
                doc.Load(FILEPATH);

                XmlNodeList parameters = doc.SelectNodes("quality-parameters/" + name);
                foreach (XmlNode item in parameters)
                {
                    string value = item.SelectSingleNode("value").InnerText;
                    string date = item.SelectSingleNode("date").InnerText;

                    lista.Add(new Parameter { Name = name, Value = value, Date = date });
                }

                return Ok(lista);
            }
            else
            {
                return NotFound();
            }

        }

    }
}
