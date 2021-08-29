using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.Entities
{
    public class SecondaryCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PrimaryCategory PrimaryCategory { get; set; }
        public int PrimaryCategoryId { get; set; }

        public Product Product { get; set; }


    }
}
