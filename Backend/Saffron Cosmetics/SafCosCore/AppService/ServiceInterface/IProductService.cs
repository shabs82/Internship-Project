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
        Product GetProductById(string id);
        List<Product> ReadAllProducts();
        Product UpdateProduct(string id);
        Product DeleteProduct(string id);

       


    }
}
