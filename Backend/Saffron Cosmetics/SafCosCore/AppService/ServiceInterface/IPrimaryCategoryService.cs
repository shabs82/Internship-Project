using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SafCos.Core.Entities;


namespace SafCos.Core.AppService.ServiceInterface
{
   public interface IPrimaryCategoryService
    {
        PrimaryClassifier CreatePrimClass(PrimaryClassifier primaryClassifier);
        PrimaryClassifier ReadPrimClassById(string Id);
        List<PrimaryClassifier> ReadAllPrimClass();
        PrimaryClassifier UpdatePrimClass(string Id);
        PrimaryClassifier DeletePrimClass(string Id);



    }
}
