using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SafCos.Core.Entities;

namespace SafCos.Core.AppService.ServiceInterface
{
   public interface IProductService
    {
        Product CreateProduct(Product product);
        Product GetProductById(int id);
        List<Product> ReadAllProducts();
        Product UpdateProduct(int id);
        Product DeleteProduct(int id);

       


    }
}
