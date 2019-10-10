using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        int SaveChanges();
        T GetRepository<T>();
    }
}
