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
        private readonly IAuthenticationHelper _authenticationHelper;
        

        public UserService(IUserRepo userRepo , IAuthenticationHelper authentication)
        {
            _userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo), "Repository cannot be null.");
            _authenticationHelper = authentication ?? throw new ArgumentNullException(nameof(authentication), "Authentication Helper cannot be null.");
        }

        User IUserService.CreateUser(LoginInputModel createdUser)
        {
            byte[] passwordNewUserHash, passwordNewUserSalt;
            _authenticationHelper.CreatePasswordHash(createdUser.Password, out passwordNewUserHash, out passwordNewUserSalt);
            // hash password
            var User = new User()
            {
                Email = createdUser.Username,
                FirstName = createdUser.FirstName,
                LastName = createdUser.LastName,
                Address = createdUser.Address,
                PostCode = createdUser.PostCode,
                PhoneNumber = createdUser.PhoneNumber,
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

        public User FindUserByUsername(string username) 
        {
            var user = _userRepo.ReadByUsername(username);

            if (user == null) throw new ArgumentException("This username does not exist");
            return user;
        }
    }
}
