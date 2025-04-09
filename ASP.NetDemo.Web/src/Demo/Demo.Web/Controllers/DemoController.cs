using Demo.Models.Demo.Web;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class DemoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new IndexModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(IndexModel model)
        {
            return View(model);
        }
    }
}
