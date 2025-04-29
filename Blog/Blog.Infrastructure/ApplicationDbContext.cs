using Blog.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blog.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssebly;
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }

        public ApplicationDbContext(string connectionString, string migrationAssebly)
        {
            _connectionString = connectionString;
            _migrationAssebly = migrationAssebly;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString, (x) => x.MigrationsAssembly(_migrationAssebly));
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
