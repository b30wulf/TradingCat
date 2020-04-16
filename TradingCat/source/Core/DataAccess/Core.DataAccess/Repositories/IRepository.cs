using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.DataAccess.Repositories
{
    public interface IRepository<T> where T : IEntity, new()
    {
        Task<T> AddAsync(T entity);
        T Add(T entity);
        T Remove(T entity);
        T Update(T entity);
        Task<List<T>> ListAsync(Expression<Func<T, bool>> predicate = null);
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);
    }
}