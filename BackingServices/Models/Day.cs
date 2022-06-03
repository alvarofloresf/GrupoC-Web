using System;
using System.Collections.Generic;
using System.Text;

namespace BackingServices.Models
{
    public class Day
    {
        public string opens_at { get; set; }
        public string closes_at { get; set; }
        public bool is_closed { get; set; }
    }
}
