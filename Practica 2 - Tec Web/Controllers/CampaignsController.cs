﻿using Logic.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<CampaignsController> logger;

        public CampaignsController(CampaignManager campaignManager, ILogger<CampaignsController> logger)
        {
            _campaignManager = campaignManager;
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult GetCampaigns()
        {
            logger.LogInformation("Se esta obteniendo una campania");
            return Ok(_campaignManager.GetCampaigns());
        }

        /*[HttpGet]
        [Route("idCampaign")]
        public IActionResult GetIdNumber()
        {
            return Ok(_campaignManager.GetSSN());
        }*/
        
        [HttpGet]
        [Route("search-partners")]
        public IActionResult GetRestaurant()
        {
            logger.LogInformation("Se esta obteniendo un restaurante como sponsor");
            return Ok(_campaignManager.GetSSN());
        }
        
        [HttpPost]
        [Route("createCampaign")]
        public IActionResult CreateCampaign([FromBody] Logic.Models.Campaign campaign)
        {
            logger.LogInformation("Se esta creando una campania");
            return Ok(_campaignManager.CreateCampaign(campaign));
        }

        [HttpPut]
        [Route("updateCampaign")]
        public IActionResult UpdateCampaign([FromBody] Logic.Models.Campaign campaign)
        {
            logger.LogWarning("Se esta actualizando una campania");
            return Ok(_campaignManager.UpdateCampaign(campaign));
        }
    }
}
