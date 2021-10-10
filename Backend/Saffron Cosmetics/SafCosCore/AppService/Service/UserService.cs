using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.AppService.Validators;
using SafCos.Core.DomainService;
using SafCos.Core.Entities;
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

        public UserService(IUserRepo userRepo , UserValidator userValidator)
        {
            _userRepo = userRepo;
            _userValidator = userValidator;

        }
        public User CreateUser(User createdUser)
        {
            throw new NotImplementedException();
        }

        public User DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User FindUserById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepo.ReadAllUsers();
        }

        public User UpdateUser(User userUpdate)
        {
            throw new NotImplementedException();
        }

        public User ValidateUser(LoginInputModel loginInputModel)
        {
            throw new NotImplementedException();
        }
    }
}
