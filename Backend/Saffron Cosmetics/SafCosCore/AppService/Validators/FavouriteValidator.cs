using SafCos.Core.AppService.ValidatorInterface;
using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.AppService.Validators
{
    public class FavouriteValidator : IFavouriteValidator
    {
        

        public void DefaultValidation(int userId)
        {
            if (userId <= 0 )
            {
                throw new NullReferenceException("inavalid user , please log in");
            }
          
        }

        public void ValidateFavourite(Favourite favourite)
        {
          if (favourite.Id <= 0)
            {
                throw new NullReferenceException();
            }

        }


    }
}
