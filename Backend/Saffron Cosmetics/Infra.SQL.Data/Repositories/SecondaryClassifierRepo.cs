using SafCos.Core.DomainService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.SQL.Data.Repositories
{
    public class SecondaryClassifierRepo : ISecondaryClassifierRepo
    {
        private readonly SafCosmeticsContext _ctx;

        public SecondaryClassifierRepo(SafCosmeticsContext ctx)
        {
            ctx = _ctx;

        }
    }
}
