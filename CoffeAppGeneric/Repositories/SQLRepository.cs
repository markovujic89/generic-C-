using System;
using System.Collections.Generic;
using System.Linq;
using CoffeeAppGeneric.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoffeeAppGeneric.Repositories
{
    public class SQLRepository<T> : ISqlRepository<T> where T : class, IEntityBase
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public SQLRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}