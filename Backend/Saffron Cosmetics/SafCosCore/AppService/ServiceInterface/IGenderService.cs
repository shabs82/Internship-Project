using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.AppService.ServiceInterface
{
   public interface IGenderService
    {
        Gender CreateGender(Gender gender);

        Gender ReadGenderById(int id);

        Gender ReadAllGender();

        Gender UpdateGender(int id);

        Gender DeleteGender(int id);
    }
}
