using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SafCos.Core.Entities;

namespace SafCos.Core.AppService.ServiceInterface
{
   public interface IProductService
    {
        List<Product> ReadAllProducts();
        Product GetProductById(int id);
        Product UpdateProduct(Product prodToUpdate);
    }
}
