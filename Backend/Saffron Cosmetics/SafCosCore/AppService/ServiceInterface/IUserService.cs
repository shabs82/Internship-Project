﻿using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.AppService.ServiceInterface
{
   public interface IUserService
    {
        User CreateUser(User createdUser);

        User FindUserById(int id);
        IEnumerable<User> GetAllUsers();

        User UpdateUser(User userUpdate);

       
        User DeleteUser(int id);

        
        User ValidateUser(LoginInputModel loginInputModel);
        String ValidateUser(Tuple<string, string> tuple);
    }
}