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
        SecondaryCategory ReadSecClass(string id);
        List<SecondaryCategory> ReadAllSecClass();
        SecondaryCategory UpdateSecClass(string id);
        SecondaryCategory DeleteSecClass(string id);


    }
}
