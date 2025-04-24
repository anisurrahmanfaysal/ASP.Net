using Microsoft.EntityFrameworkCore;
using News.Domain.Entities;

namespace News.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        DbSet<Book> Books { get; set; }
        DbSet<Author> Authors { get; set; }
    }
}
