using Microsoft.EntityFrameworkCore;
using Note.Domain.Entities;
using Note.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Infrastructure.Repositories
{
    public class Repository<T, G> : IRepository<T, G> where T : IEntity<G>
    {
        public readonly DbContext _dbContext;
        public Repository(DbContext context)
        {
            _dbContext = context;
        }
        public void Add(T entity) { }
        public void Update(T entity) { }
        public void Delete(T entity) { }
    }
}
