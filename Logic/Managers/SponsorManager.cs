using Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Managers
{
    public class SponsorManager
    {
        private UnitOfWork _uow;
        public SponsorManager(UnitOfWork uow)
        {
            _uow = uow;
        }

        public List<Logic.Models.Sponsor> GetSponsors()
        {
            List<Database.Models.Sponsor> sponsorFromDB = _uow.SponsorRepository.GetAllSponsors().Result;
            List<Logic.Models.Sponsor> mappedSponsors = new List<Logic.Models.Sponsor>();
            foreach (Database.Models.Sponsor sponsor in sponsorFromDB)
            {
                mappedSponsors.Add(new Logic.Models.Sponsor() 
                {
                    Name =  sponsor.Name,
                    Description = sponsor.Description,
                    PhoneNumber = sponsor.PhoneNumber
                });
            }
            return mappedSponsors;
        }
    }
}
