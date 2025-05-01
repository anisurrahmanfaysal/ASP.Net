using Note.Domain;
using Note.Domain.Entities;
using Note.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        public BookService(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }
        public void AddBook(Book book)
        {
            _applicationUnitOfWork.BookRepository.Add(book);
            _applicationUnitOfWork.Save();
        }
    }
}
