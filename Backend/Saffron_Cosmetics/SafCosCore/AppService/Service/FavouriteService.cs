using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.AppService.ValidatorInterface;
using SafCos.Core.DomainService;
using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafCos.Core.AppService.Service
{
    public class FavouriteService : IFavouriteService
    {
        readonly IFavouriteValidator _favouriteValidator;
        readonly IFavouriteRepo _favouriteRepo;

        public FavouriteService(IFavouriteValidator favouriteValidator, IFavouriteRepo favouriteRepo)
        {
            _favouriteValidator = favouriteValidator ?? throw new NullReferenceException("Validator cannot be null"); 
            _favouriteRepo = favouriteRepo ?? throw new NullReferenceException("Repo cannot be null");
        }
        public Favourite DeleteFavouritesById(int id)
        {
            _favouriteValidator.DefaultValidation(id);
            return _favouriteRepo.DeleteFavouritesById(id);
        }

        //public IEnumerable<Favourite> FindLoggedInUsersFavouriteProducts()
        //{
        //    return _favouriteRepo.FindLoggedInUsersFavouriteProducts().ToList();
        //}

        public IEnumerable<Favourite> GetFavouritesByUserId( int userId)
        {
            _favouriteValidator.DefaultValidation(userId);
            return _favouriteRepo.GetFavouritesByUserId(userId);
        }

        public Favourite New(Favourite favourite)
        {
            Favourite fav = new Favourite()
            {
                Id = favourite.Id
            };
            return fav;
        }
        public  Favourite AddFavourite(Favourite favourite)
        {
            _favouriteValidator.ValidateFavourite(favourite);
            return _favouriteRepo.AddFavourite(favourite);
        }
    }
}
