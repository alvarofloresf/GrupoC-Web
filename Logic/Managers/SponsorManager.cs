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

        public Logic.Models.Sponsor CreateSponsor(Logic.Models.Sponsor sponsor)
        {
            Database.Models.Sponsor sponsorToCreate = new Database.Models.Sponsor()
            {
                Id = new Guid(),
                Name = sponsor.Name, 
                Description = sponsor.Description,
                PhoneNumber = sponsor.Description
            };
            _uow.SponsorRepository.CreateSponsor(sponsorToCreate);
            _uow.Save();

            return new Logic.Models.Sponsor()
            {
                Id = sponsorToCreate.Id,
                Name = sponsorToCreate.Name,
                Description = sponsorToCreate.Description,
                PhoneNumber = sponsorToCreate.Description
            };
        }

        public Logic.Models.Sponsor UpdateSponsor(Logic.Models.Sponsor sponsor)
        {
            Database.Models.Sponsor sponsorToUpdate = _uow.SponsorRepository.GetSponsorById(sponsor.Id);

            sponsorToUpdate.Name = sponsor.Name;
            sponsorToUpdate.Description = sponsor.Description;
            sponsorToUpdate.PhoneNumber = sponsor.PhoneNumber;



            _uow.SponsorRepository.UpdateSponsor(sponsorToUpdate);
            _uow.Save();

            return new Logic.Models.Sponsor()
            {
                Id = sponsorToUpdate.Id,
                Name = sponsorToUpdate.Name,
                Description = sponsorToUpdate.Description,
                PhoneNumber = sponsorToUpdate.PhoneNumber
            };
        }

        // aumentar metodo delete
    }
}
