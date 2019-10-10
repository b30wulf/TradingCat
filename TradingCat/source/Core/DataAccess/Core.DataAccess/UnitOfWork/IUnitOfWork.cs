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
