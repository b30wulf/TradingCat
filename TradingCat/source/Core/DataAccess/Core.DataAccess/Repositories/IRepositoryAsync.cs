using Core.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.DataAccess.Repositories
{
    public interface IRepositoryAsync<T> where T : IEntity, new()
    {
        Task<T> AddAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<IEnumerable<T>> ListAsync();
        Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> predicate);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);
    }
}