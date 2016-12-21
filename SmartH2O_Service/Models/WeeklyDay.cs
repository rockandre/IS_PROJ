using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartH2O_Service.Models
{
    public class WeeklyDay
    {
        public int day { get; set; }
        public float min { get; set; }
        public float avg { get; set; }
        public float max { get; set; }
    }
}