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

        [Route("parameters/{name}/{year}/{month}/{day}")]
        public IHttpActionResult GetParametersHourlyByDay(string name, string year, string month, string day)
        {
            name = name.ToUpper();
            if (name == "PH" || name == "CI2" || name == "NH3")
            {
                List<Parameter> lista = new List<Parameter>();
                List<float> listAvgHourAndMaxMin = new List<float>();
                float[] avgHour = new float[24];
                float[] sumValues = new float[24];
                int[] counterHour = new int[24];
                float min = 40;
                float max = 1;
                
                XmlDocument doc = new XmlDocument();
                doc.Load(FILEPATH);

                XmlNodeList parameters = doc.SelectNodes("quality-parameters/" + name);
                foreach (XmlNode item in parameters)
                {
                    string value = item.SelectSingleNode("value").InnerText;
                    DateTime date = Convert.ToDateTime(item.SelectSingleNode("date").InnerText);
                    
                    if( date.Year == int.Parse(year) && date.Month == int.Parse(month) && date.Day == int.Parse(day))
                    {
                        switch (date.Hour)
                        {
                            case 00:
                                sumValues[0] += float.Parse(value.Replace('.', ','));
                                counterHour[0]++;
                                break;
                            case 01:
                                sumValues[1] += float.Parse(value.Replace('.', ','));
                                counterHour[1]++;
                                break;
                            case 02:
                                sumValues[2] += float.Parse(value.Replace('.', ','));
                                counterHour[2]++;
                                break;
                            case 03:
                                sumValues[3] += float.Parse(value.Replace('.', ','));
                                counterHour[3]++;
                                break;
                            case 04:
                                sumValues[4] += float.Parse(value.Replace('.', ','));
                                counterHour[4]++;
                                break;
                            case 05:
                                sumValues[5] += float.Parse(value.Replace('.', ','));
                                counterHour[5]++;
                                break;
                            case 06:
                                sumValues[6] += float.Parse(value.Replace('.', ','));
                                counterHour[6]++;
                                break;
                            case 07:
                                sumValues[7] += float.Parse(value.Replace('.', ','));
                                counterHour[7]++;
                                break;
                            case 08:
                                sumValues[8] += float.Parse(value.Replace('.', ','));
                                counterHour[8]++;
                                break;
                            case 09:
                                sumValues[9] += float.Parse(value.Replace('.', ','));
                                counterHour[9]++;
                                break;
                            case 10:
                                sumValues[10] += float.Parse(value.Replace('.', ','));
                                counterHour[10]++;
                                break;
                            case 11:
                                sumValues[11] += float.Parse(value.Replace('.', ','));
                                counterHour[11]++;
                                break;
                            case 12:
                                sumValues[12] += float.Parse(value.Replace('.', ','));
                                counterHour[12]++;
                                break;
                            case 13:
                                sumValues[13] += float.Parse(value.Replace('.', ','));
                                counterHour[13]++;
                                break;
                            case 14:
                                sumValues[14] += float.Parse(value.Replace('.', ','));
                                counterHour[14]++;
                                break;
                            case 15:
                                sumValues[15] += float.Parse(value.Replace('.', ','));
                                counterHour[15]++;
                                break;
                            case 16:
                                sumValues[16] += float.Parse(value.Replace('.', ','));
                                counterHour[16]++;
                                break;
                            case 17:
                                sumValues[17] += float.Parse(value.Replace('.', ','));
                                counterHour[17]++;
                                break;
                            case 18:
                                sumValues[18] += float.Parse(value.Replace('.', ','));
                                counterHour[18]++;
                                break;
                            case 19:
                                sumValues[19] += float.Parse(value.Replace('.', ','));
                                counterHour[19]++;
                                break;
                            case 20:
                                sumValues[20] += float.Parse(value.Replace('.', ','));
                                counterHour[20]++;
                                break;
                            case 21:
                                sumValues[21] += float.Parse(value.Replace('.', ','));
                                counterHour[21]++;
                                break;
                            case 22:
                                sumValues[22] += float.Parse(value.Replace('.', ','));
                                counterHour[22]++;
                                break;
                            case 23:
                                sumValues[23] += float.Parse(value.Replace('.', ','));
                                counterHour[23]++;
                                break;
                        }
                    }
                    
                    if (float.Parse(value.Replace('.', ',')) <= min)
                    {
                        min = float.Parse(value.Replace('.', ','));
                    }
                    if (float.Parse(value.Replace('.', ',')) >= max)
                    {
                        max = float.Parse(value.Replace('.', ','));
                    }
                }

                for (int i = 0; i < 24; i++)
                {
                    listAvgHourAndMaxMin[i] = (sumValues[i] / counterHour[i]);
                }

                listAvgHourAndMaxMin[24] = min;
                listAvgHourAndMaxMin[25] = max;

                return Ok(listAvgHourAndMaxMin);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("parameters/{name}/{date1}/{date2}")]
        public IHttpActionResult GetParametersByDay(string name, DateTime date1, DateTime date2)
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

                }

            }
                return NotFound();
        }
    }
}
