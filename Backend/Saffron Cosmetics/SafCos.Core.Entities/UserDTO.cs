using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.Entities
{
    public class UserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
        public string PhoneNumber { get; set; }


        public string Email { get; set; }
        public string Password { get; set; }
    }
}
