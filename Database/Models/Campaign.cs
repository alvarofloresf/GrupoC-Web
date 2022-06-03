using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Models
{
    public class Campaign : Entity
    {
        public string NameCampaign { get; set; }
        public string TypeCampaign { get; set; }
        public string DescriptionCampaign { get; set; }
        public Sponsor CustomerSponsor { get; set; }
        public bool Enable { get; set; }
    }
}
