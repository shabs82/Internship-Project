using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.AppService.ServiceInterface
{
    public interface IFavouriteService
    {
        IEnumerable<Favourite> GetFavouritesByUserId( int userId);

        //IEnumerable<Favourite> FindLoggedInUsersFavouriteProducts();

        Favourite DeleteFavouritesById(int id);

        Favourite AddFavourite(Favourite favourite);
    }
}
