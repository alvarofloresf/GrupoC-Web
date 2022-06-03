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
                    CustomerSponsorId = campaign.CustomerSponsorId,
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
                CustomerSponsorId = campaign.CustomerSponsorId,
                Enable = "False"
            };
            _uow.CampaignRepository.CreateCampaign(campaignToCreate);
            _uow.Save();

            return new Logic.Models.Campaign()
            {
                Id = campaignToCreate.Id,
                NameCampaign = campaignToCreate.NameCampaign,
                TypeCampaign = campaignToCreate.TypeCampaign,
                DescriptionCampaign = campaignToCreate.DescriptionCampaign,
                CustomerSponsorId = campaignToCreate.CustomerSponsorId, //modificar
                Enable = campaignToCreate.Enable
            };
        }

        public Logic.Models.Campaign UpdateCampaign(Logic.Models.Campaign campaign)
        {
            Database.Models.Campaign campaignToUpdate = _uow.CampaignRepository.GetCampaignById(campaign.Id);

            campaignToUpdate.NameCampaign = campaign.NameCampaign;
            campaignToUpdate.TypeCampaign = campaign.TypeCampaign;
            campaignToUpdate.DescriptionCampaign = campaign.DescriptionCampaign;
            campaignToUpdate.CustomerSponsorId = campaign.CustomerSponsorId;
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

        public Logic.Models.Campaign DeleteCampaign(Logic.Models.Campaign campaign)
        {
            Database.Models.Campaign campaignToDelete = _uow.CampaignRepository.GetCampaignById(campaign.Id);
            
        }
    }
}
