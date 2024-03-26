using MagicTube.Models;

namespace MagicTube.Repository.IRepository
{
    public interface IVillaRepository
    {
        Task Create(Villa entity);
    }
}
