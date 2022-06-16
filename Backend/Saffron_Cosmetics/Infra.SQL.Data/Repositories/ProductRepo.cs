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
            Product prod = _ctx.Products.FirstOrDefault(prod => prod.Id == id);

           if(prod.Availability < 5)
            {
                throw new Exception("low on stock");

            }
           if(prod.Availability <2 && prod.Availability >=0)
            {
                throw new ArgumentException("out of stock");

            }
            return prod;
        }

        public List<Product> ReadAllProducts()
        {
            return _ctx.Products.ToList();
        }

        public async Task<IEnumerable<Product>> Search(string name)
        {
            IQueryable<Product> query = _ctx.Products;

            if (!string.IsNullOrEmpty(name))
            {
                var queryDown = query.Where(p => p.Name.Contains(name));
                var capitalName = char.ToUpper(name[0]) + name.Substring(1);
                var queryUp = query.Where(p => p.Name.Contains(capitalName));
                query = queryDown.Concat(queryUp);
            }
            return await query.ToListAsync();
        }

        public Product UpdateProduct(Product prodToUpdate)
        {
            _ctx.Products.Attach(prodToUpdate).State = EntityState.Modified;
            _ctx.SaveChanges();
            return prodToUpdate;
        }
    }
}
