using Note.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Domain.Repositories
{
    public interface IBookRepository : IRepository<Book,Guid>
    {
        List<Book> GetLatestBooks();
    }
}
