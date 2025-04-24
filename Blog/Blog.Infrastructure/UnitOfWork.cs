using Blog.Domain;
using Blog.Domain.Repositories;
using Blog.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;
        public IBookRepository BookRepository { get; set; }
        public IAuthorRepository AuthorRepository { get; set; }
        public UnitOfWork(DbContext context)
        {
            _dbContext = context;
            BookRepository = new BookRepository((ApplicationDbContext) _dbContext);
            AuthorRepository = new AuthorRepository((ApplicationDbContext) _dbContext);
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
