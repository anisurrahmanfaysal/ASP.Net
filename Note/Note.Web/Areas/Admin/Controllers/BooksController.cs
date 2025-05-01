using MediatR;
using Microsoft.AspNetCore.Mvc;
using Note.Application.Features.Books.Commands;
using Note.Domain.Entities;
using Note.Domain.Services;
using Note.Web.Areas.Admin.Models;

namespace Note.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
        //private readonly IBookService _bookService;
        private readonly IMediator _mediator;
        public BooksController(IMediator mediator)
        {
            //_bookService = bookService;
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            var model = new BookAddCommand();
            return View(model);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(BookAddCommand bookAddCommand)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(bookAddCommand);
                //_bookService.AddBook(new Book { Title = model.Title});
            }
            return View(bookAddCommand);
        }
    }
}
