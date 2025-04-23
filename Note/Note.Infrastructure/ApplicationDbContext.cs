using Microsoft.EntityFrameworkCore;
using Note.Domain.Entities;

namespace Note.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
