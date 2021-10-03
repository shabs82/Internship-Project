using SafCos.Core.AppService.Validators;
using SafCos.Core.DomainService;
using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.SQL.Data.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly SafCosmeticsContext _safCosmeticsCtx;
        //private readonly UserValidator _userValidator;


        public UserRepo(SafCosmeticsContext safCosmeticsCtx)
        {
            _safCosmeticsCtx = safCosmeticsCtx;
        }
        public User CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public User DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> ReadAllUsers()
        {
           return _safCosmeticsCtx.Users.ToList();
        }

        public User ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User userUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
