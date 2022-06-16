using Microsoft.AspNetCore.Mvc;
using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SafCos.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavouriteController : ControllerBase
    {
        private readonly IFavouriteService _favService;
        public FavouriteController(IFavouriteService favService)
        {
            _favService = favService;
        }
        // GET: api/<FavouriteController>
        [HttpGet]
        //public ActionResult<List<Favourite>> Get()
        //{
        //    try
        //    {
        //        if(_favService.FindLoggedInUsersFavouriteProducts() != null)
        //        {
        //            return Ok(_favService.FindLoggedInUsersFavouriteProducts());
        //        }
        //        return NotFound();
        //    }
        //    catch (SystemException)
        //    {
        //        return BadRequest();
        //    }

        //}


        // GET api/<FavouriteController>/5
        [HttpGet("{id}")]
        public ActionResult<List<Favourite>> Get(int userId)
        {
            try
            {
                if (userId <= 0)
                {
                    return BadRequest("invalid id");
                }
                return Ok(_favService.GetFavouritesByUserId(userId));
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }





        // POST api/<FavouriteController>
        [HttpPost]
        public ActionResult<Favourite> Post([FromBody] Favourite favourite)
        {

            try
            {
                return Ok(_favService.AddFavourite(favourite));
            }

            catch (MissingMemberException e)
            {
                return NotFound(e.Message);
            }
        }

    


        // PUT api/<FavouriteController>/5
        //[HttpPut("{id}")]
        //public ActionResult<Favourite> Put(int id, [FromBody] Favourite favourite)
        //{
        //    try
        //    {
        //        return Ok(_favService.RemoveFavoriteFromUser(favourite));
        //    }

        //    catch (MissingMemberException e)
        //    {
        //        return NotFound(e.Message);
        //    }
        //}

        // DELETE api/<FavouriteController>/5
        [HttpDelete("{id}")]
        public ActionResult<Favourite> Delete([FromBody] int id)
        {
            try
            {
                if (id <= 0 )
                {
                    return BadRequest("invalid id");
                }
                return Ok(_favService.DeleteFavouritesById(id));
            }
            catch (System.Exception)
            {
                return BadRequest();
            }

        }
    }
}
