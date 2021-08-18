﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.Entities
{
   public class Product
    {
        public int Id { get; set; }
        public int SecondaryClassifier { get; set; }
        public int SecondaryClassifierId { get; set; }
        public int ProductCode { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public int BrandId { get; set; }
        public int Availability { get; set; }
        public string Description { get; set; }
        public Boolean ForHim { get; set; }
        public Boolean ForHer { get; set; }


    }
}