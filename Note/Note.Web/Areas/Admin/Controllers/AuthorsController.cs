using AutoMapper;
using Demo.Domain;
using Microsoft.AspNetCore.Mvc;
using Note.Application.Exceptions;
using Note.Domain.Entities;
using Note.Domain.Services;
using Note.Infrastructure;
using Note.Web.Areas.Admin.Models;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Note.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthorsController(ILogger<AuthorsController> logger, 
        IAuthorService authorService, IMapper mapper) : Controller
    {
        private readonly IAuthorService _authorService = authorService;
        private readonly ILogger<AuthorsController> _logger = logger;
        public readonly IMapper _mapper = mapper;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            var model = new AddAuthorModel();
            return View(model);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Add(AddAuthorModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var author = _mapper.Map<Author>(model);
                    author.Id = IdentityGenerator.NewSequentialGuid();

                    _authorService.AddAuthor(author);

                    TempData.Put("ResponseMessage", new ResponseModel
                    {
                        Message = "Author Added",
                        Type = ResponseTypes.Success
                    });

                    return RedirectToAction("Index");
                }
                catch(DuplicateAuthorNameException de)
                {
                    TempData.Put("ResponseMessage", new ResponseModel
                    {
                        Message = de.Message,
                        Type = ResponseTypes.Danger
                    });
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Failed to add author.");

                    TempData.Put("ResponseMessage", new ResponseModel
                    {
                        Message = "Failed to Add Author",
                        Type = ResponseTypes.Danger
                    });
                    return View(model);
                }
            }
            return View(model);
        }
        public JsonResult GetAuthorJsonData([FromBody]AuthorListModel model)
        {
            try
            {
                var (data, total, totalDisplay) = _authorService.GetAuthors(model.PageIndex, model.PageSize,
                    model.FormatSortExpression("Name", "Biography", "Rating", "Id"), model.Search);
                var authors = new
                {
                    recordsTotal = total,
                    recordFiltered = totalDisplay,
                    data = (from record in data
                            select new string[]
                            {
                                HttpUtility.HtmlEncode(record.Name),
                                HttpUtility.HtmlEncode(record.Biography),
                                record.Rating.ToString(),
                                record.Id.ToString()
                            }).ToArray()
                };
                return Json(authors);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "There was a problem in getting authors");
                return Json(DataTables.EmptyResult);
            }
        }
    }
}
