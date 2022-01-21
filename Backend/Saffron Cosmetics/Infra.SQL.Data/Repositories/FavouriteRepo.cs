using Microsoft.EntityFrameworkCore;
using SafCos.Core.DomainService;
using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.SQL.Data.Repositories
{
    public class FavouriteRepo : IFavouriteRepo
    {
        private readonly SafCosmeticsContext _ctx;

        public FavouriteRepo(SafCosmeticsContext ctx)
        {
            _ctx = ctx;
        }
        public Favourite DeleteFavouritesById(int id)
        {
            var fav = _ctx.Remove(new Favourite() { Id = id });
            _ctx.SaveChanges();
            return fav.Entity;

        }

        //public IEnumerable<Favourite> FindLoggedInUsersFavouriteProducts()
        //{
        //    return _ctx.Favourites.ToList();
        //}

        public IEnumerable<Favourite> GetFavouritesByUserId(int userId)
        {
            return _ctx.Favourites.Where(u => u.userId == userId).ToList();
        }

        public Favourite AddFavourite(Favourite favourite)
        {
            _ctx.Attach(favourite).State = EntityState.Added;
            _ctx.SaveChanges();
            return favourite;
        }


    }
}
