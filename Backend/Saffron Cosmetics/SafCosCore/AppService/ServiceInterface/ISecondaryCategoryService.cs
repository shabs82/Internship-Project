using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SafCos.Core.Entities;

namespace SafCos.Core.AppService.ServiceInterface
{
   public interface ISecondaryCategoryService
    {
        SecondaryCategory CreateSecClass(SecondaryCategory secondaryClassifier);
        SecondaryCategory ReadSecClass(int id);
        List<SecondaryCategory> ReadAllSecClass();
        SecondaryCategory UpdateSecClass(int id);
        SecondaryCategory DeleteSecClass(int id);


    }
}
