using Microsoft.EntityFrameworkCore;
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
            _safCosmeticsCtx.Attach(user).State = EntityState.Added;
            _safCosmeticsCtx.SaveChanges();
            return user;
        }

        public User DeleteUser(int id)
        {
            var user = _safCosmeticsCtx.Remove(new User() { Id = id });
            _safCosmeticsCtx.SaveChanges();
            return user.Entity;
        }

        public IEnumerable<User> ReadAllUsers()
        {
           return _safCosmeticsCtx.Users.ToList();
        }

        public User ReadById(int id)
        {
            return _safCosmeticsCtx.Users.FirstOrDefault(user => user.Id == id);
        }

        public User ReadByUsername(string username)
        {
            return _safCosmeticsCtx.Users.ToList().FirstOrDefault(user => user.Email == username);
        }

        public User UpdateUser(User userUpdate)
        {
            _safCosmeticsCtx.Attach(userUpdate).State = EntityState.Modified;
            _safCosmeticsCtx.Update(userUpdate);
            _safCosmeticsCtx.SaveChanges();
            return userUpdate;
        }
    }
}
