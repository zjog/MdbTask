using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MdbTask.Data.Interfaces
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> Find(
                Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Remove(T entity);

        public IEnumerable<T> GetAll();
    }
}
