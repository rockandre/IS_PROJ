using SmartH2O_Service.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Xml;

namespace SmartH2O_Service.Controllers
{
    public class AlarmsController : ApiController
    {
        string FILEPATH = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, @"App_Data\alarms-data.xml");

        [Route("alarms/byDay/{year}/{month}/{day}")]
        public IHttpActionResult GetAlarmsByDay(int year, int month, int day)
        {
                List<Alarm> lista = new List<Alarm>();
                XmlDocument doc = new XmlDocument();
                doc.Load(FILEPATH);

                XmlNodeList alarms = doc.SelectNodes("alarms/PH");
                foreach (XmlNode item in alarms)
                {
                DateTime date = Convert.ToDateTime(item.SelectSingleNode("date").InnerText);
                if(date.Day == day && date.Month == month && date.Year == year)
                {
                    string value = item.SelectSingleNode("value").InnerText;
                    string ruleOperator = item.SelectSingleNode("rule/operator").InnerText;
                    string ruleValue = item.SelectSingleNode("rule/value").InnerText;
                    lista.Add(new Alarm { Name = "PH", Value = value, Date = date, RuleOperator = ruleOperator, RuleValue = ruleValue });
                }
                
                }

                if(lista.Count != 0)
            {
                return Ok(lista);
            } else
            {
                return NotFound();
            }
                
            

        }
    }
}
