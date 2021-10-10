using Microsoft.EntityFrameworkCore;
using SafCos.Core.DomainService;
using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.SQL.Data.Repositories
{
    public class ProductRepo : IProductRepo
    {
        private readonly SafCosmeticsContext _ctx;

        public ProductRepo(SafCosmeticsContext safCosmeticsContext)
        {
            _ctx = safCosmeticsContext;
        }

        public Product CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            return _ctx.Products.FirstOrDefault(prod => prod.Id == id);
        }

        public List<Product> ReadAllProducts()
        {
            return _ctx.Products.ToList();
        }

        public Product UpdateProduct(Product prodToUpdate)
        {
            _ctx.Products.Attach(prodToUpdate).State = EntityState.Modified;
            _ctx.SaveChanges();
            return prodToUpdate;
        }
    }
}
