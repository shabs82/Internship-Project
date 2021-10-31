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
    public class SecondaryCategoryRepo : ISecondaryCategoryRepo
    {
        private readonly SafCosmeticsContext _ctx;

        public SecondaryCategoryRepo(SafCosmeticsContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Product> GetProductsBySecondaryCategoryId(int id)
        {
            return _ctx.Products.Where(p => p.SecondaryCategoryId == id).Include(p => p.Gender).Include(p => p.Brand).Include(p => p.SecondaryCategory);
        }
    }
}
