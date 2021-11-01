using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SafCos.Core.AppService.ServiceInterface;
using SafCos.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SafCos.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SecondaryCategoryController : ControllerBase
    {
        private readonly ISecondaryCategoryService _secCatategoryService;

        public SecondaryCategoryController(ISecondaryCategoryService secCatService)
        {
            _secCatategoryService = secCatService;
        }
        // GET api/<SecondaryCategoryController>/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Product>> Get(int id)
        {
            if (id < 1)
            {
                return BadRequest("Request Failed - Id must be greater than zero");
            }
            IEnumerable<Product> productsBySecondaryCategory = _secCatategoryService.GetProductsBySecondaryCategoryId(id);
            List<Product> secCategoryProductList = productsBySecondaryCategory.ToList();
            if (secCategoryProductList.Count == 0)
            {
                return StatusCode(404, "No posters in collection with id " + id + " were found");
            }
            return StatusCode(200, secCategoryProductList);
            return null;
        }
    }
}
