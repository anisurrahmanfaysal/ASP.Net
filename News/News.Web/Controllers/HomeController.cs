using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using News.Web.Models;

namespace News.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProduct _product;

        public HomeController(ILogger<HomeController> logger, [FromKeyedServices("Config1")] IProduct product)
        {
            _logger = logger;
            _product = product;
        }

        public IActionResult Index()
        {
            var price = _product.GetPrice();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
