using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.Entities
{
    public class SecondaryCategory
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PrimaryCategory { get; set; }
        public string PrimaryCategoryId { get; set; }
       
        
    }
}
