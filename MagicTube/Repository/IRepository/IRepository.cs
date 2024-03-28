using MagicTube.Models;
using System.Linq.Expressions;

namespace MagicTube.Repository.IRepository
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAll(Expression<Func<T, bool>>? filter = null);

        Task<T> Get(Expression<Func<T, bool>> filter = null, bool tracked = true);
        Task Create(T entity);

        Task Remove(T entity);

        Task Save();
    }
}

