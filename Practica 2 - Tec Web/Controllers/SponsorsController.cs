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
    public class SponsorsController : ControllerBase
    {
        private SponsorManager _sponsorManager;
        public SponsorsController(SponsorManager sponsorManager)
        {
            _sponsorManager = sponsorManager;
        }
        [HttpGet]
        public IActionResult GetSponsors()
        {
            return Ok(_sponsorManager.GetSponsors());
        }
        /*[HttpGet]
        [Route("id-number")]
        public IActionResult GetIdNumber()
        {
            return Ok(_sponsorManager.GetSSN());
        }*/

        [HttpPost]
        [Route("createSponsor")]
        public IActionResult CreateSponsor([FromBody] Logic.Models.Sponsor sponsor)
        {
            return Ok(_sponsorManager.CreateSponsor(sponsor));
        }

        [HttpPut]
        [Route("updateSponsor")]
        public IActionResult UpdateSponsor([FromBody] Logic.Models.Sponsor sponsor)
        {
            return Ok(_sponsorManager.UpdateSponsor(sponsor));
        }
    }
}
