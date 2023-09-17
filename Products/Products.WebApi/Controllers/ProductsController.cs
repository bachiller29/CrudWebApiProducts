using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Products.Business.Interfaces.Services;
using Products.Models;

namespace Products.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {
            var result = await _productsService.GetAllProducts();
            return result.ToList();
        }

        [HttpGet("{id}")]
        public Product GetProductByID(int id)
        {
            var result = _productsService.GetProductsById(id);
            return result;
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<ActionResult<Product>> PostProducts(Product product)
        {
            var result = _productsService.CreateProducs(product);
            return result;
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducts(int id, Product product)
        {
            if (id != product.IdProduct) return BadRequest();

            try
            {
                _productsService.UpdateState(product);
            }
            catch (DbUpdateConcurrencyException)
            {

                throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var product = await _productsService.Delete(id);
            if (product == null) return NotFound();
            return product;
        }

    }
}
