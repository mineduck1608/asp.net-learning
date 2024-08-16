using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIApp.Models;

namespace WebAPIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public static List<Product> products = new List<Product>();


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(products);
        }

        [HttpPost]
        public IActionResult Create(ProductVM productVM)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = productVM.Name,
                Price = productVM.Price,
            };
            products.Add(product);
            return Ok(products);
        }
    }
}
