using FluentValidation;
using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.AppService.Validators;
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
        private readonly ProductValidator _prodValidator;

        
        public ProductService(IProductRepo productRepo, ProductValidator productValidator)
        {
            _productRepo = productRepo;
            _prodValidator = productValidator;
            
        }

        public Product CreateProduct(Product product)
        {
           
            return _productRepo.CreateProduct(product);

        }
        public List<Product> ReadAllProducts()
        {
            return _productRepo.ReadAllProducts();
        }
        public Product GetProductById(int id)
        {
            if(id < 0 )
            {
                throw new NullReferenceException("Invalid ID");
            }

            return _productRepo.GetProductById(id);
        }
        public Product UpdateProduct(Product prodToUpdate)
        {
            if (prodToUpdate.Id < 0 || prodToUpdate.Name == null)
                throw new ArgumentNullException("Invalid Id or Name");
            if (prodToUpdate.Price <= 0)
                throw new ArgumentOutOfRangeException("price cannot be 0 or in negative");
            if (prodToUpdate.SkuCode == null)
                throw new Exception("skuCode cannot be empty");
            if (prodToUpdate.Description == string.Empty)
                throw new MissingFieldException("please describe the product");
            if (prodToUpdate.Availability <= 5)
                throw new NullReferenceException("product is unavailable");
            if (prodToUpdate.ProductCode == null)
                throw new NullReferenceException("invalid product code");
            return _productRepo.UpdateProduct(prodToUpdate);
        }

       

        public Product DeleteProduct(int id)
        {
            if (id <= 0)
                throw new NullReferenceException();
            return _productRepo.GetProductById(id);
        }

        public Task<IEnumerable<Product>> Search(string name)
        {
            return _productRepo.Search(name);
        }
    }
}
