using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafCos.Core.Entities;


namespace SafCos.Core.DomainService
{
    public interface IProductRepo
    {
        List<Product> ReadAllProducts();
        Product GetProductById(int id);
        Product UpdateProduct(Product prodToUpdate);
        Product CreateProduct(Product product);
        Product DeleteProduct(int id);
        Task<IEnumerable<Product>> Search(string name);
    }
}
