using Architecht_TemplateMethodDesignPattern.Models;
using Architecht_TemplateMethodDesignPattern.Validation.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Architecht_TemplateMethodDesignPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> _productList = new();

        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            ProductValidator validator = new ProductValidator(product);
            if (!validator.IsSuccess) return Ok(validator.Results);

            _productList.Add(product);

            return Ok();
        }
    }
}
