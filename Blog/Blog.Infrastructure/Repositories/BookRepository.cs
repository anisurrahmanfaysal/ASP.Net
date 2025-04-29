using Blog.Domain.Entities;
using Blog.Domain.Repositories;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories
{
    public class BookRepository : Repository<Book, Guid> , IBookRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public BookRepository(ApplicationDbContext context)
            : base(context)
        {
            _dbContext = context;
        }

        public List<Book> GetLatestBooks()
        {
            throw new NotImplementedException();
        }
    }
}
