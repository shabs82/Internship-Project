using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SafCos.Core.Entities;

namespace SafCos.Core.AppService.ServiceInterface
{
   public interface ISecondaryClassifierService
    {
        SecondaryClassifier CreateSecClass(SecondaryClassifier secondaryClassifier);
        SecondaryClassifier ReadSecClass(string id);
        List<SecondaryClassifier> ReadAllSecClass();
        SecondaryClassifier UpdateSecClass(string id);
        SecondaryClassifier DeleteSecClass(string id);


    }
}
