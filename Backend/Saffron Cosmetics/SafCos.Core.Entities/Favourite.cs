using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.Entities
{
    public class Favourite
    {
        public int Id { get; set; }

        public Product Product { get; set; }
        public int productid { get; set; }

        public User user { get; set; }

        public int userId { get; set; }


    }
}
