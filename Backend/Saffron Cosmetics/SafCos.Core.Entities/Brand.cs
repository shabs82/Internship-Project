﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }

        public Product Product { get; set; }
    }
}
