using MagicTube.Models;
using System.Linq.Expressions;

namespace MagicTube.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {

        Task<Villa> Update(Villa entity);

    }
}
