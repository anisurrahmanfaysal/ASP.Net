using Blog.Domain.Entities;
using Blog.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories
{
    public class AuthorRepository : Repository<Author, Guid> , IAuthorRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public AuthorRepository(ApplicationDbContext context)
            : base(context)
        {
            _dbContext = context;
        }
    }
}
