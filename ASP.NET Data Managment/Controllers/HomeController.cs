using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Data_Managment.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult About() {
            return View();
        }

        public IActionResult Contact() {
            return View();
        }

        public IActionResult Galery() {
            return View();
        }
    }
}
