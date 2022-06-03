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
        public int CustomerSponsorId { get; set; }
        public string Enable { get; set; }
    }
}
