using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.Entities
{
   public class Product
    {
        public int Id { get; set; }
        public SecondaryClassifier SecondaryClassifier { get; set; }
        public int SecondaryClassifierId { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        public int Availability { get; set; }
        public string Description { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }



    }
}
