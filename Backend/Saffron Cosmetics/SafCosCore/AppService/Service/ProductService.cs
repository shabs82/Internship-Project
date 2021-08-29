using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.DomainService;
using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.AppService.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;

        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        public List<Product> ReadAllProducts()
        {
            return _productRepo.ReadAllProducts();
        }
        public Product GetProductById(int id)
        {
            return _productRepo.GetProductById(id);
        }
        public Product UpdateProduct(Product prodToUpdate)
        {
            return _productRepo.UpdateProduct(prodToUpdate);
        }
    }
}
