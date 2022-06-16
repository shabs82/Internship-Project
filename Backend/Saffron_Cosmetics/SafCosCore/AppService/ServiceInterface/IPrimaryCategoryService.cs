using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SafCos.Core.Entities;


namespace SafCos.Core.AppService.ServiceInterface
{
   public interface IPrimaryCategoryService
    {
        PrimaryCategory CreatePrimClass(PrimaryCategory primaryCategory);
        PrimaryCategory ReadPrimClassById(int Id);
        List<PrimaryCategory> ReadAllPrimClass();
        PrimaryCategory UpdatePrimClass(int Id);
        PrimaryCategory DeletePrimClass(int Id);



    }
}
