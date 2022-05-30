using Logic;
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
    public class OfferController : ControllerBase
    {
        private IUserManager _userManager;
        public OfferController(IUserManager userManager)
        {
            _userManager = userManager;

        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_userManager.GetUsers());
        }
        [HttpPost]
        public IActionResult PostUser(User user)
        {
            return Ok(_userManager.PostUser(user));
        }
        [HttpPut]
        public IActionResult PutUser(User user)
        {
            return Ok(_userManager.PutUser(user));
        }
        [HttpDelete]
        public IActionResult DeleteUser(int userId)

        {
            return Ok(_userManager.DeleteUser(userId));
        }
    }
}