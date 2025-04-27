using Demo.Domain.Entities;
using Demo.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Repositories
{
    public abstract class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TKey : IComparable 
        where TEntity : class,IEntity<TKey>
    {
        private readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(TEntity entityToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(TEntity entityToUpdate)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IList<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(TKey id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync(TKey id)
        {
            throw new NotImplementedException();
        }

        public int GetCount(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetCountAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Remove(TKey id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(TEntity entityToDelete)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(TKey id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
