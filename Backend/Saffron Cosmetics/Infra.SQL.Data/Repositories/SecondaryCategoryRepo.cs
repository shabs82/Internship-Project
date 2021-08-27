using SafCos.Core.DomainService;
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
            ctx = _ctx;

        }
    }
}
