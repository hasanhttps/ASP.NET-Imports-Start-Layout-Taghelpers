using ASP.NET_Data_Managment.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Data_Managment.Controllers {
    public class ProductController : Controller {

        // Fields

        private List<Product> products = new List<Product>() {
            new Product(),
            new Product(),
            new Product(),
            new Product(),
            new Product()
    };

        // Methods

        [HttpGet] // Default
        public IActionResult CreateProduct() {
            return View();
        }
    }
}
