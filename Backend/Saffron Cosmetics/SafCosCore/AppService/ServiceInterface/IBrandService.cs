using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SafCos.Core.Entities;

namespace SafCos.Core.AppService.ServiceInterface
{
   public interface IBrandService
    {
        Brand CreateBrand(Brand brand);
        Brand GetBrandById(string id);
        List<Brand> GetAllBrands();
        Brand UpdateBrand(string id);
        Brand DeleteBrand(string id);


       
    }
}
