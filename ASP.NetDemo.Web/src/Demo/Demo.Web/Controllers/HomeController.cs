using System.Diagnostics;
using Demo.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IItem _item;

        public HomeController(ILogger<HomeController> logger, IItem item)
        {
            _logger = logger;
            _item = item;
        }

        public IActionResult Index()
        {
            var amount = _item.GetAmount();
            _logger.LogInformation("Im in index page.");
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
