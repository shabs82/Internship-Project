using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SafCos.Core.Entities;

namespace SafCos.Core.AppService.ValidatorsInterface
{
   public interface IProductValidator
    {
        void DefaultValidation(Product product);
    }
}
