using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Models
{
    public class Campaign
    {
        public Guid Id { get; set; }
        public string NameCampaign { get; set; }
        public string TypeCampaign { get; set; }
        public string DescriptionCampaign { get; set; }
        public int CustomerSponsorId { get; set; }
        public string Enable { get; set; }
    }
}
