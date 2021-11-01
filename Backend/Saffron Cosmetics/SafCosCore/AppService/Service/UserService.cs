using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.AppService.Validators;
using SafCos.Core.DomainService;
using SafCos.Core.Entities;
using SafCos.Core.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.AppService.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo ;
        private readonly UserValidator _userValidator;
        private readonly IAuthenticationHelper _authenticationHelper;

        public UserService(IUserRepo userRepo , UserValidator userValidator, IAuthenticationHelper authentication)
        {
            _userRepo = userRepo;
            _userValidator = userValidator;
            _authenticationHelper = authentication;

        }

        User IUserService.CreateUser(LoginInputModel createdUser)
        {
            byte[] passwordNewUserHash, passwordNewUserSalt;
            _authenticationHelper.CreatePasswordHash(createdUser.Password, out passwordNewUserHash, out passwordNewUserSalt);
            // hash password
            var User = new User()
            {
                Username = createdUser.Username,
                PasswordHash = passwordNewUserHash,
                PasswordSalt = passwordNewUserSalt,
                IsAdmin = false,
            };
            _authenticationHelper.GenerateToken(User);
            return _userRepo.CreateUser(User);
        }

        public User DeleteUser(int id)
        {
            return _userRepo.DeleteUser(id);
        }

        public User FindUserById(int id)
        {
            return _userRepo.ReadById(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepo.ReadAllUsers();
        }

        public User UpdateUser(User userUpdate)
        {
            return _userRepo.UpdateUser(userUpdate);
        }

        public User ValidateUser(LoginInputModel loginInputModel)
        {
            throw new NotImplementedException();
        }

     

        
    }
}
