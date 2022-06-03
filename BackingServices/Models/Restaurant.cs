using System;
using System.Collections.Generic;
using System.Text;

namespace BackingServices.Models
{
    public class Restaurant
    {
        public int id { get; set; }
        public string uid { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public string review { get; set; }
        public string logo { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }
        public List<Day> hours { get; set; }
    }
}
