using Logic.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_3___Tec_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignsController : ControllerBase
    {
        private CampaignManager _campaignManager;
        public CampaignsController(CampaignManager campaignManager)
        {
            _campaignManager = campaignManager;
        }

        [HttpGet]
        public IActionResult GetCampaigns()
        {
            return Ok(_campaignManager.GetCampaigns());
        }

        /*[HttpGet]
        [Route("idCampaign")]
        public IActionResult GetIdNumber()
        {
            return Ok(_campaignManager.GetSSN());
        }*/

        [HttpPost]
        [Route("createCampaign")]
        public IActionResult CreateCampaign([FromBody] Logic.Models.Campaign campaign)
        {
            return Ok(_campaignManager.CreateCampaign(campaign));
        }

        [HttpPut]
        [Route("updateCampaign")]
        public IActionResult UpdateCampaign([FromBody] Logic.Models.Campaign campaign)
        {
            return Ok(_campaignManager.UpdateCampaign(campaign));
        }
    }
}
