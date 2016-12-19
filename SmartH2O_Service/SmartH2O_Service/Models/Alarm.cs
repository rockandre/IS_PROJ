using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartH2O_Service.Models
{
    public class Alarm
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime Date { get; set; }
        public string RuleOperator { get; set; }
        public string RuleValue { get; set; }
    }
}