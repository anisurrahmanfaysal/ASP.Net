using Microsoft.EntityFrameworkCore;
using News.Domain.Entities;
using News.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Infrastructure.Repositories
{
    public class BookRepository : Repository<Book, Guid> , IBookRepository
    {
        public readonly ApplicationDbContext Context;
        public BookRepository(ApplicationDbContext context) 
            : base(context)
        {
            Context = context;
        }
    }
}
