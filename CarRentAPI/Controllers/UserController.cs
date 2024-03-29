using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using CarRentAPI.Models;

namespace CarRentAPI.Controllers
{
    [Route("api/[controller]-[Action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public List<User> users;

        public UserController()
        {
            users = new List<User> { 
                new User { Id = 1, Username = "FecskeFarok", Password = "12345", Name="Peter Arpad"},
                new User { Id = 1, Username = "TarhonyaFa", Password = "nemletezik", Name="Gyurcsany Viktor"},
                new User { Id = 1, Username = "Teperto", Password = "kremes", Name="Orban Ferenc"}
            };
        }

        [HttpPost]
        public IActionResult Login([FromForm] string _username, [FromForm] string _password)
        {
            var userExists = users.FirstOrDefault(x => x.Username == _username);
            if (userExists != null)
            {
                if (userExists.Password == _password)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

