using Demo.Domain;
using Note.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Domain.Repositories
{
    public interface IAuthorRepository : IRepository<Author, Guid>
    {
        (IList<Author> data, int total, int totalDisplay) GetPagedAuthors(int pageIndex, 
            int pageSize, string? order, DataTablesSearch search);
    }
}
