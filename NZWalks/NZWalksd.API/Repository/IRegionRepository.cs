using NZWalksd.API.Models.Domain;

namespace NZWalksd.API.Repository
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync();
    }
}
