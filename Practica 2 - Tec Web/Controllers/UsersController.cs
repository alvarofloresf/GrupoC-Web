using Logic.Managers;
using Logic.Models;
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
    public class UsersController : ControllerBase
    {
        private IUserManager _userManager;
        public UsersController(IUserManager userManager)
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
        [HttpDelete]
        public IActionResult DeleteUser(int userId)

        {
            return Ok(_userManager.DeleteUser(userId));
        }
        [HttpPut]
        public IActionResult PutUser(User user)
        {
            return Ok(_userManager.PutUser(user));
        }
    }
}
