using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.AppService.ValidatorInterface
{
   public interface IFavouriteValidator
    {
        void DefaultValidation(int userId);

        void ValidateFavourite(Favourite favourite);

        //void DeafultValidation(int id);

    }
}
