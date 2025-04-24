using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Repositories
{
    public interface IBookRepository : IRepository<Book, Guid>
    {
    }
}
