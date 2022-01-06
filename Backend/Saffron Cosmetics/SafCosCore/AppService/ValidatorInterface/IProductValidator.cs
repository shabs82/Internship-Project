using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafCos.Core.Entities;

namespace SafCos.Core.AppService.ValidatorInterface
{
    public interface IProductValidator
    {
        void DefaultValidation(Product product);

        void DeleteProduct(int id);

        void UpdateProduct(Product prodToUpdate);
    }
}
