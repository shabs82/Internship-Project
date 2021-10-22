using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.Entities;
using SafCos.Core.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SafCos.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private IAuthenticationHelper _authHelper;

        public UserController(IUserService userService, IAuthenticationHelper authenticationHelper)
        {
            _userService = userService;
            _authHelper = authenticationHelper;
        }
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        //[HttpPost]
        //public IActionResult Login([FromBody] JObject data)
        //{
        //    try
        //    {
        //        //Tuple is used because it's easier to pair with JSON Data (JObject data), allowing us to retrieve both username and password inputs.
        //        var validatedUser = _userService.ValidateUser(new Tuple<string, string>(data["username"].ToString(), data["password"].ToString()));

        //        return Ok(new
        //        {
        //            username = data["username"].ToString(),
        //            token = validatedUser
        //        });
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest(e.Message);
        //    }
        //}

        // POST api/user/token
        [HttpPost]
        public IActionResult Login([FromBody] LoginInputModel model)
        {
            var user = _userService.GetAllUsers().FirstOrDefault(u => u.Username == model.Username);

            //Cheking if user exists
            if (user == null)
                return Unauthorized();

            //Checks if pass is correct
            if (!_authHelper.VerifyPasswordHash(model.Password, user.PasswordHash, user.PasswordSalt))
                return Unauthorized();

            //Authentication successfull
            return Ok(new
            {
                username = user.Username,
                token = _authHelper.GenerateToken(user)
            });
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
