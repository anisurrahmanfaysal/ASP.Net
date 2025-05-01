using Demo.Domain;
using Note.Domain.Entities;
using Note.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Infrastructure.Repositories
{
    public class AuthorRepository : Repository<Author, Guid> , IAuthorRepository
    {
        public AuthorRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public (IList<Author> data, int total, int totalDisplay) GetPagedAuthors(int pageIndex, 
            int pageSize, string? order, DataTablesSearch search)
        {
            if (string.IsNullOrWhiteSpace(search.Value))
                return GetDynamic(null, order, null, pageIndex, pageSize, true);
            else
                return GetDynamic(x => x.Name.Contains(search.Value), order,
                    null, pageIndex, pageSize,true);
        }
    }
}
