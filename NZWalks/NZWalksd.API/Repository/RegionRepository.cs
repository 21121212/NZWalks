using Microsoft.EntityFrameworkCore;
using NZWalksd.API.Data;
using NZWalksd.API.Models.Domain;

namespace NZWalksd.API.Repository
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext _nzWalksDbContext;

        public RegionRepository(NZWalksDbContext nzWalksDbContext)
        {
            this._nzWalksDbContext = nzWalksDbContext;
        }

        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await _nzWalksDbContext.Regions.ToListAsync();
        }
    }
}
