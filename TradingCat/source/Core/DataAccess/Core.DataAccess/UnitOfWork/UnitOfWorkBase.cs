using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.UnitOfWork
{
    public abstract class UnitOfWorkBase : IUnitOfWork
    {
        private readonly DbContext _dbContext;

        public UnitOfWorkBase(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public abstract T GetRepository<T>();

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
