using Microsoft.EntityFrameworkCore;
using Note.Domain;
using Note.Domain.Repositories;
using Note.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;
        public IBookRepository BookRepository { get; private set; }
        public IAuthorRepository AuthorRepository { get; private set; }
        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
            BookRepository = new BookRepository((ApplicationDbContext) _dbContext);
            AuthorRepository = new AuthorRepository((ApplicationDbContext) _dbContext);
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }


    }
}
