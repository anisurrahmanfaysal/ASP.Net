using Note.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Domain.Features.Books.Queries
{
    public interface IBookGetQuery
    {
        Book Get(Guid id);
    }
}
