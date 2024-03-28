using MagicTube.Repository.IRepository;
using MagicTube.Models;
using System.Linq.Expressions;
using MagicTube.Data;
using Microsoft.EntityFrameworkCore;

namespace MagicTube.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public async Task<Villa> Update(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}

