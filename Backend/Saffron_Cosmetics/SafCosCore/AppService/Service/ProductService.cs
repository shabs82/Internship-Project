using FluentValidation;
using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.AppService.ValidatorInterface;
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
        //private readonly ProductValidator _prodValidator;
        private readonly IProductValidator _productValidator;

        
        public ProductService(IProductRepo productRepo, IProductValidator productValidator)
        {
            _productRepo = productRepo ?? throw new NullReferenceException("Repo cannot be null");
            _productValidator = productValidator ?? throw new NullReferenceException("Validator cannot be null"); ;
            
        }

        public Product CreateProduct(Product product)
        {
            _productValidator.DefaultValidation(product);
            return _productRepo.CreateProduct(product);

        }
        public List<Product> ReadAllProducts()
        {
            return _productRepo.ReadAllProducts().ToList();
        }
        public Product GetProductById(int id)
        {
            if(id <= 0 )
            {
                throw new NullReferenceException("Invalid ID");
            }
            
            var product = _productRepo.GetProductById(id);

            if (product.Availability < 5 && product.Availability > 0)
            {
                product.Availability = -1;
            }
            else if (product.Availability == 0)
            {
                throw new IndexOutOfRangeException("Product is not available. Sold Out");
            }

            return product;
        }
        public Product UpdateProduct(Product prodToUpdate)
        {
            _productValidator.UpdateProduct(prodToUpdate);
            return _productRepo.UpdateProduct(prodToUpdate);
        }      

        public Product DeleteProduct(int id)
        {
            if (id <= 0)
            {
                throw new NullReferenceException("Invalid ID");
            }
            _productValidator.DeleteProduct(id);
            return _productRepo.GetProductById(id);
        }

        public Task<IEnumerable<Product>> Search(string name)
        {
            return _productRepo.Search(name);
        }
    }
}
