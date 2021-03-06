﻿using SmartH2O_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using System.Web;
using System.Xml;
using System.Globalization;

namespace SmartH2O_Service.Controllers
{
    public class ParametersController : ApiController
    {

        string FILEPATH = @"C:\SmartH2O_Data\SmartH2O_Log\param-data.xml";

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
                List<Hour> listAvgHourAndMaxMin = new List<Hour>();
                float[] avgHour = new float[24];
                float[] sumValues = new float[24];
                int[] counterHour = new int[24];
                float[] min = new float[24];
                float[] max = new float[24];

                for (int i = 0; i < 24; i++)
                {
                    sumValues[i] = 0;
                    counterHour[i] = 0;
                    min[i] = 20;
                    max[i] = 0;
                }
                XmlDocument doc = new XmlDocument();
                doc.Load(FILEPATH);

                XmlNodeList parameters = doc.SelectNodes("quality-parameters/" + name);
                foreach (XmlNode item in parameters)
                {
                    string value = item.SelectSingleNode("value").InnerText;
                    DateTime date = Convert.ToDateTime(item.SelectSingleNode("date").InnerText);

                    if (date.Year == int.Parse(year) && date.Month == int.Parse(month) && date.Day == int.Parse(day))
                    {
                        for (int k = 0; k < 24; k++)
                        {
                            if (date.Hour == k)
                            {
                                sumValues[k] += float.Parse(value.Replace('.', ','));
                                counterHour[k]++;

                                if (float.Parse(value.Replace('.', ',')) <= min[k])
                                {
                                    min[k] = float.Parse(value.Replace('.', ','));
                                }
                                if (float.Parse(value.Replace('.', ',')) >= max[k])
                                {
                                    max[k] = float.Parse(value.Replace('.', ','));
                                }
                            }
                        }
                    }
                }


                for (int j = 0; j < 24; j++)
                {

                    if (min[j] == 20)
                    {
                        min[j] = 0;
                    }
                    if (counterHour[j] != 0)
                    {
                        listAvgHourAndMaxMin.Add(new Hour { hour = j, min = min[j], avg = sumValues[j] / counterHour[j], max = max[j] });
                    }
                    else
                    {
                        listAvgHourAndMaxMin.Add(new Hour { hour = j, min = min[j], avg = 0, max = max[j] });
                    }
                }


                return Ok(listAvgHourAndMaxMin);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("parameters/{name}/{year1}/{month1}/{day1}/{year2}/{month2}/{day2}")]
        public IHttpActionResult GetParametersByDay(string name, int year1, int month1, int day1,
                                                                int year2, int month2, int day2)
        {

            name = name.ToUpper();
            if (name == "PH" || name == "CI2" || name == "NH3")
            {
                List<WeeklyDay> lista = new List<WeeklyDay>();
                List<float> array = new List<float>();

                XmlDocument doc = new XmlDocument();
                doc.Load(FILEPATH);

                DateTime date1 = new DateTime(year1, month1, day1);
                DateTime date2 = new DateTime(year2, month2, day2);
                DateTime dateAux = date1.Date;
                TimeSpan difference = date2 - date1;
                double nDays = difference.TotalDays;

                for (int i = 0; i <= nDays; i++)
                {
                    array.Clear();
                    XmlNodeList parameters = doc.SelectNodes("quality-parameters/" + name);
                    foreach (XmlNode item in parameters)
                    {
                        DateTime date = Convert.ToDateTime(item.SelectSingleNode("date").InnerText.Split(' ')[0]).Date;

                        if (dateAux.ToShortDateString().CompareTo(date.ToShortDateString()) == 0)
                        {
                            array.Add(float.Parse(item.SelectSingleNode("value").InnerText.Replace('.', ',')));
                        }

                    }
                    if (array.Count != 0)
                    {
                        lista.Add(new WeeklyDay { day = dateAux.Day, min = array.Min(), avg = array.Average(), max = array.Max() });
                    }
                    else
                    {
                        lista.Add(new WeeklyDay { day = dateAux.Day, min = 0, avg = 0, max = 0 });
                    }
                    dateAux = dateAux.AddDays(1);
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