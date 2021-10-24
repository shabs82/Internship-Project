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
            return _userRepo.CreateUser(createdUser);
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

        public string ValidateUser(Tuple<string, string> tuple)
        {
            throw new NotImplementedException();
        }
    }
}
