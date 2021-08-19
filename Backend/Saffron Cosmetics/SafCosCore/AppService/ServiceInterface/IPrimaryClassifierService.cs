using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SafCos.Core.Entities;


namespace SafCos.Core.AppService.ServiceInterface
{
   public interface IPrimaryClassifierService
    {
        PrimaryClassifier CreatePrimClass(int Id, string Name);
        PrimaryClassifier ReadPrimClassById(int Id);
        List<PrimaryClassifier> ReadAllPrimClass();
        PrimaryClassifier UpdatePrimClass(int Id);
        PrimaryClassifier DeletePrimClass(int Id);



    }
}
