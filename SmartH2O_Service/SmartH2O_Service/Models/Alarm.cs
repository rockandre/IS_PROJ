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
        public string Date { get; set; }
        public string Rule { get; set; }
    }
}