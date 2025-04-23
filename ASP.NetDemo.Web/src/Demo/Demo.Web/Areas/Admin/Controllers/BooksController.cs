﻿using Demo.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Demo.Domain.Services;
using Demo.Domain.Entities;
using Microsoft.AspNetCore.Authorization;

namespace Demo.Web.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Roles = "Admin,HR")]
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            var model = new AddBookModel();
            return View(model);
        }
        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Add(AddBookModel model)
        {
            if (ModelState.IsValid)
            {
                _bookService.AddBook(new Book { Title = model.Title });
            }
            return View(model);
        }
    }
}
