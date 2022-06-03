using Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Managers
{
    public interface ISponsorManager
    {
        public List<Sponsor> GetSponsors();
        public Sponsor PostSponsor(Sponsor sponsor);
        public Sponsor DeleteSponsor(int sponsorId);
        public Sponsor PutSponsor(Sponsor sponsor);
    }
}
