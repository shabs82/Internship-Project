using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.Entities
{
   public  class PrimaryCategory
    {
        public int Id { get; set; }   
        public string Name { get; set; }

        public ICollection<SecondaryCategory> SecondaryCategories { get; set; }
    }
}
