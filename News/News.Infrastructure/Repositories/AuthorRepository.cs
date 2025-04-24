using News.Domain.Entities;
using News.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Infrastructure.Repositories
{
    internal class AuthorRepository : Repository<Author, Guid> , IAuthorRepository
    {
        public readonly ApplicationDbContext Context;
        public AuthorRepository(ApplicationDbContext context)
            : base(context)
        {
            Context = context;
        }
    }
}
