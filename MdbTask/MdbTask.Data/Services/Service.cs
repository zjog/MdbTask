using MdbTask.Data.Context;
using MdbTask.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MdbTask.Data.Services
{
    /// <summary>
    /// Common service methods
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Service<T> : IService<T> where T : class
    {
        protected readonly DbSet<T> _entities;

        public Service(ApplicationDbContext context)
        {
            _entities = context.Set<T>();
        }

        public IEnumerable<T> Find(
                Expression<Func<T, bool>> predicate)
        {
            return _entities.Where(predicate);
        }
        public void Add(T entity)
        {
            _entities.Add(entity);
        }
        public void Remove(T entity)
        {
            _entities.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }
    }
}
