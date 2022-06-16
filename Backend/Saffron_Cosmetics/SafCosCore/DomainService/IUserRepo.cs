using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.DomainService
{
   public interface IUserRepo
    {
        User CreateUser(User user);

        // Read User(s)
        User ReadById(int id);
        IEnumerable<User> ReadAllUsers();

        // Update User
        User UpdateUser(User userUpdate);

        // Delete User
        User DeleteUser(int id);
        User ReadByUsername(string username);
    }
}
