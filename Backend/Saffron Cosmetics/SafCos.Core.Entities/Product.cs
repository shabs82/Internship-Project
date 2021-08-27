using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.Entities
{
   public class Product
    {
        public string Id { get; set; }
        public SecondaryCategory SecondaryCategory { get; set; }
        public string SecondaryCategoryId { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string Variant { get; set; }
        public double Price { get; set; }
        public Brand Brand { get; set; }
        public string BrandId { get; set; }
        public int Availability { get; set; }
        public string Description { get; set; }
        public int SkuCode { get; set; }
        public string Currency { get; set; }
        public string GenderId { get; set; }
        public Gender Gender { get; set; }



    }
}
