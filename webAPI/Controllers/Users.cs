using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webAPI.Models;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Users> Get()
        {
            List<Users> Users = new List<Users>();
            Users.Add(new Users
            {
                user = "test",
                email = "test@gmail.com",
                pwd = "1234"
            });
            Users.Add(new Users
            {
                user = "test1234",
                email = "test1234@gmail.com",
                pwd = "test"
            });
            return Users;
        }
        [HttpGet("{user}")]
        public Boolean Get(string user)
        {
            return true;
        }
    }
}
