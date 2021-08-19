using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SafCos.Core.Entities;

namespace SafCos.Core.AppService.ServiceInterface
{
   public interface ISecondaryClassifierService
    {
        SecondaryClassifier CreateSecClass(int Id, string Name, int PrimaryClassifierId);
        SecondaryClassifier ReadSecClass(int id);
        List<SecondaryClassifier> ReadAllSecClass();
        SecondaryClassifier UpdateSecClass(int id);
        SecondaryClassifier DeleteSecClass(int id);


    }
}
