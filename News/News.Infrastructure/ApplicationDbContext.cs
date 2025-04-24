using Microsoft.EntityFrameworkCore;
using News.Domain.Entities;

namespace News.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
