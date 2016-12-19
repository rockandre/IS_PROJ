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

            XmlNodeList alarmsPH = doc.SelectNodes("alarms/PH");
            foreach (XmlNode item in alarmsPH)
            {
                DateTime date = Convert.ToDateTime(item.SelectSingleNode("date").InnerText);
                if (date.Day == day && date.Month == month && date.Year == year)
                {
                    string value = item.SelectSingleNode("value").InnerText;
                    string ruleOperator = item.SelectSingleNode("rule/operator").InnerText;
                    string ruleValue = item.SelectSingleNode("rule/value").InnerText;
                    lista.Add(new Alarm { Name = "PH", Value = value, Date = date, RuleOperator = ruleOperator, RuleValue = ruleValue });
                }


            }

            XmlNodeList alarmsCI2 = doc.SelectNodes("alarms/CI2");
            foreach (XmlNode item in alarmsCI2)
            {
                DateTime date = Convert.ToDateTime(item.SelectSingleNode("date").InnerText);
                if (date.Day == day && date.Month == month && date.Year == year)
                {
                    string value = item.SelectSingleNode("value").InnerText;
                    string ruleOperator = item.SelectSingleNode("rule/operator").InnerText;
                    string ruleValue = item.SelectSingleNode("rule/value").InnerText;
                    lista.Add(new Alarm { Name = "CI2", Value = value, Date = date, RuleOperator = ruleOperator, RuleValue = ruleValue });
                }


            }

            XmlNodeList alarmsNH3 = doc.SelectNodes("alarms/NH3");
            foreach (XmlNode item in alarmsNH3)
            {
                DateTime date = Convert.ToDateTime(item.SelectSingleNode("date").InnerText);
                if (date.Day == day && date.Month == month && date.Year == year)
                {
                    string value = item.SelectSingleNode("value").InnerText;
                    string ruleOperator = item.SelectSingleNode("rule/operator").InnerText;
                    string ruleValue = item.SelectSingleNode("rule/value").InnerText;
                    lista.Add(new Alarm { Name = "NH3", Value = value, Date = date, RuleOperator = ruleOperator, RuleValue = ruleValue });
                }


            }

            if (lista.Count != 0)
            {
                return Ok(lista);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("alarms/between/{yearI}/{monthI}/{dayI}/{yearF}/{monthF}/{dayF}")]
        public IHttpActionResult GetAlarmsBetweenDates(int yearI, int monthI, int dayI, int yearF, int monthF, int dayF)
        {
            List<Alarm> lista = new List<Alarm>();
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);

            XmlNodeList alarmsPH = doc.SelectNodes("alarms/PH");
            foreach (XmlNode item in alarmsPH)
            {
                DateTime dateI = new DateTime(yearI, monthI, dayI);
                DateTime dateF = new DateTime(yearF, monthF, dayF++);
                DateTime date = Convert.ToDateTime(item.SelectSingleNode("date").InnerText);
                if (date > dateI && date < dateF)
                {
                    string value = item.SelectSingleNode("value").InnerText;
                    string ruleOperator = item.SelectSingleNode("rule/operator").InnerText;
                    string ruleValue = item.SelectSingleNode("rule/value").InnerText;
                    lista.Add(new Alarm { Name = "PH", Value = value, Date = date, RuleOperator = ruleOperator, RuleValue = ruleValue });
                }

            }

            XmlNodeList alarmsCI2 = doc.SelectNodes("alarms/CI2");
            foreach (XmlNode item in alarmsCI2)
            {
                DateTime dateI = new DateTime(yearI, monthI, dayI);
                DateTime dateF = new DateTime(yearF, monthF, dayF++);
                DateTime date = Convert.ToDateTime(item.SelectSingleNode("date").InnerText);
                if (date > dateI && date < dateF)
                {
                    string value = item.SelectSingleNode("value").InnerText;
                    string ruleOperator = item.SelectSingleNode("rule/operator").InnerText;
                    string ruleValue = item.SelectSingleNode("rule/value").InnerText;
                    lista.Add(new Alarm { Name = "CI2", Value = value, Date = date, RuleOperator = ruleOperator, RuleValue = ruleValue });
                }

            }

            XmlNodeList alarmsNH3 = doc.SelectNodes("alarms/NH3");
            foreach (XmlNode item in alarmsNH3)
            {
                DateTime dateI = new DateTime(yearI, monthI, dayI);
                DateTime dateF = new DateTime(yearF, monthF, dayF++);
                DateTime date = Convert.ToDateTime(item.SelectSingleNode("date").InnerText);
                if (date > dateI && date < dateF)
                {
                    string value = item.SelectSingleNode("value").InnerText;
                    string ruleOperator = item.SelectSingleNode("rule/operator").InnerText;
                    string ruleValue = item.SelectSingleNode("rule/value").InnerText;
                    lista.Add(new Alarm { Name = "NH3", Value = value, Date = date, RuleOperator = ruleOperator, RuleValue = ruleValue });
                }

            }

            if (lista.Count != 0)
            {
                return Ok(lista);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("alarms")]
        public IHttpActionResult GetAlarms()
        {
            List<Alarm> lista = new List<Alarm>();
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);

            XmlNodeList alarmsPH = doc.SelectNodes("alarms/PH");
            foreach (XmlNode item in alarmsPH)
            {
                string value = item.SelectSingleNode("value").InnerText;
                string ruleOperator = item.SelectSingleNode("rule/operator").InnerText;
                string ruleValue = item.SelectSingleNode("rule/value").InnerText;
                DateTime date = Convert.ToDateTime(item.SelectSingleNode("date").InnerText);
                lista.Add(new Alarm { Name = "PH", Value = value, Date = date, RuleOperator = ruleOperator, RuleValue = ruleValue });
            }
            XmlNodeList alarmsCI2 = doc.SelectNodes("alarms/CI2");
            foreach (XmlNode item in alarmsCI2)
            {
                string value = item.SelectSingleNode("value").InnerText;
                string ruleOperator = item.SelectSingleNode("rule/operator").InnerText;
                string ruleValue = item.SelectSingleNode("rule/value").InnerText;
                DateTime date = Convert.ToDateTime(item.SelectSingleNode("date").InnerText);
                lista.Add(new Alarm { Name = "CI2", Value = value, Date = date, RuleOperator = ruleOperator, RuleValue = ruleValue });
            }
            XmlNodeList alarmsNH3 = doc.SelectNodes("alarms/NH3");
            foreach (XmlNode item in alarmsNH3)
            {
                string value = item.SelectSingleNode("value").InnerText;
                string ruleOperator = item.SelectSingleNode("rule/operator").InnerText;
                string ruleValue = item.SelectSingleNode("rule/value").InnerText;
                DateTime date = Convert.ToDateTime(item.SelectSingleNode("date").InnerText);
                lista.Add(new Alarm { Name = "NH3", Value = value, Date = date, RuleOperator = ruleOperator, RuleValue = ruleValue });
            }

            if (lista.Count != 0)
            {
                return Ok(lista);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
