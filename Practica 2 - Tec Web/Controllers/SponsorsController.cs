using Logic.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_3___Tec_Web.Controllers
{
    [Route("sponsor-management")]
    [ApiController]
    public class SponsorsController : ControllerBase
    {
        private SponsorManager _sponsorManager;
        public SponsorsController(SponsorManager sponsorManager)
        {
            _sponsorManager = sponsorManager;
        }
        [HttpGet]
        [Route("sponsors")]
        public IActionResult GetSponsors()
        {
            return Ok(_sponsorManager.GetSponsors());
        }
    }
}
