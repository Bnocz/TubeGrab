using MagicTube.Models;
using System.Linq.Expressions;

namespace MagicTube.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {

        Task<VillaNumber> UpdateAsync(VillaNumber entity);

    }
}
