using Microsoft.EntityFrameworkCore;
using News.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Infrastructure.Repositories
{
    public class BookRepository : Repository<Book, Guid>
    {
        public readonly ApplicationDbContext Context;
        public BookRepository(ApplicationDbContext context) 
            : base(context)
        {
            Context = context;
        }
    }
}
