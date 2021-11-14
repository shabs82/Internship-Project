using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.Entities;
using SafCos.Core.Helper;

namespace SafCos.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IUserService _userService;
        private IAuthenticationHelper _authHelper;

        public TokenController(IUserService userService, IAuthenticationHelper authenticationHelper)
        {
            _userService = userService;
            _authHelper = authenticationHelper;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginInputModel model)
        {
            var user = _userService.GetAllUsers().FirstOrDefault(u => u.Email == model.Username);

            //Cheking if user exists
            if (user == null)
                return Unauthorized();

            //Chek if pass is correct
            if (!_authHelper.VerifyPasswordHash(model.Password, user.PasswordHash, user.PasswordSalt))
                return Unauthorized();

            //Authentication successfull
            return Ok(new
            {
                id = user.Id,
                username = user.Email,
                token = _authHelper.GenerateToken(user),
                firstName = user.FirstName,
                lastName = user.LastName,
                phoneNumber = user.PhoneNumber,
                address = user.Address,
                postCode = user.PostCode
            });
        }
    }
}
