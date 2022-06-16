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
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{search}/filteredProducts")]
        public async Task<ActionResult<IEnumerable<Product>>> Search(string name)
        {
            try
            {
                var result = await _productService.Search(name);

                if (result.Any())
                {
                    return Ok(result);
                }
                return NotFound("no products") ;
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            try
            {
                if (_productService.ReadAllProducts() != null)
                {
                    return Ok(_productService.ReadAllProducts());
                }
                return NotFound();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            try
            {
                if (id < 1)
                {
                    return BadRequest("Id must be bigger than 0");
                }
                return Ok(_productService.GetProductById(id));
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }


        [HttpPut("{id}")]
        public ActionResult<Product> Put(int id, [FromBody] Product product)
        {
            try
            {
                if (id < 1 || product.Id != id)
                {
                    return BadRequest("Enter correct id. ID must be bigger than 1");
                }
                return _productService.UpdateProduct(product);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

    }
}
