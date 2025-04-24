using Microsoft.AspNetCore.Mvc;
using Note.Web.Areas.Admin.Models;

namespace Note.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            var model = new AddBookModel();
            return View(model);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Add(AddBookModel model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}
