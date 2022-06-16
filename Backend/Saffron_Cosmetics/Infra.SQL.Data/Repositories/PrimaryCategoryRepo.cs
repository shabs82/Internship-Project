using SafCos.Core.DomainService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.SQL.Data.Repositories
{
    public class PrimaryCategoryRepo : IPrimaryCategoryRepo
    {
        private readonly SafCosmeticsContext _ctx;

        public PrimaryCategoryRepo(SafCosmeticsContext ctx)
        {
            ctx = _ctx;

        }
    }
}
