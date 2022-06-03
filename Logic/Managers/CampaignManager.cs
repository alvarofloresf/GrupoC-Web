using Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Managers
{
    public class CampaignManager
    {
        private UnitOfWork _uow;
        public CampaignManager(UnitOfWork uow)
        {
            _uow = uow;
        }

        public List<Logic.Models.Campaign> GetCampaigns()
        {
            List<Database.Models.Campaign> campaignFromDB = _uow.CampaignRepository.GetAllCampaigns().Result;
            List<Logic.Models.Campaign> mappedCampaign = new List<Logic.Models.Campaign>();
            foreach (Database.Models.Campaign campaign in campaignFromDB)
            {
                mappedCampaign.Add(new Logic.Models.Campaign()
                {
                    NameCampaign = campaign.NameCampaign,
                    TypeCampaign = campaign.TypeCampaign,
                    DescriptionCampaign = campaign.DescriptionCampaign,
                    CustomerSponsor = null,
                    Enable = campaign.Enable
                });
            }
            return mappedCampaign;
        }

        public Logic.Models.Campaign CreateCampaign(Logic.Models.Campaign campaign)
        {
            Database.Models.Campaign campaignToCreate = new Database.Models.Campaign()
            {
                Id = new Guid(),
                NameCampaign = campaign.NameCampaign,
                TypeCampaign = campaign.TypeCampaign,
                DescriptionCampaign = campaign.DescriptionCampaign,
                CustomerSponsor = null,
                Enable = false
            };
            _uow.CampaignRepository.CreateCampaign(campaignToCreate);
            _uow.Save();

            return new Logic.Models.Campaign()
            {
                Id = campaignToCreate.Id,
                NameCampaign = campaignToCreate.NameCampaign,
                TypeCampaign = campaignToCreate.TypeCampaign,
                DescriptionCampaign = campaignToCreate.DescriptionCampaign,
                CustomerSponsor = null, //modificar
                Enable = campaignToCreate.Enable
            };
        }

        public Logic.Models.Campaign UpdateCampaign(Logic.Models.Campaign campaign)
        {
            Database.Models.Campaign campaignToUpdate = _uow.CampaignRepository.GetCampaignById(campaign.Id);

            campaignToUpdate.NameCampaign = campaign.NameCampaign;
            campaignToUpdate.TypeCampaign = campaign.TypeCampaign;
            campaignToUpdate.DescriptionCampaign = campaign.DescriptionCampaign;
            // aca agreagar el sponsor
            campaignToUpdate.Enable = campaign.Enable;



            _uow.CampaignRepository.UpdateCampaign(campaignToUpdate);
            _uow.Save();

            return new Logic.Models.Campaign()
            {
                Id = campaignToUpdate.Id,
                NameCampaign = campaignToUpdate.NameCampaign,
                TypeCampaign = campaignToUpdate.TypeCampaign,
                DescriptionCampaign = campaignToUpdate.DescriptionCampaign,
                Enable = campaignToUpdate.Enable
            };
        }

        //aumentar metodo delete
    }
}
