using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Infra.SQL.Data.DB
{
   public interface IDBInitialiser
    {
        void SeedDB(SafCosmeticsContext ctx);
    }
}
