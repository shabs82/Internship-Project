using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SafCos.Core.Entities;

namespace SafCos.Core.AppService.ServiceInterface
{
   public interface ISecondaryCategoryService
    {
        IEnumerable<Product> GetProductsBySecondaryCategoryId(int id);



        SecondaryCategory CreateSecClass(SecondaryCategory secondaryClassifier);
        List<SecondaryCategory> ReadAllSecClass();
        SecondaryCategory UpdateSecClass(int id);
        SecondaryCategory DeleteSecClass(int id);
        
    }
}
