using ApiWebApplication.Models;

using Microsoft.AspNetCore.Mvc;

namespace ApiWebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ApplicationDbContext context, ILogger<ProductsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return this._context.Products.ToArray();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);
            if(product != null)
            {
                return Ok(product);
            }

            return NotFound();
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<ActionResult<Product>> Post([FromBody] Product product)
        {
            this._context.Products.Add(product);
            await this._context.SaveChangesAsync();

            return CreatedAtAction(nameof(Post), new { id = product.Id }, product);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}