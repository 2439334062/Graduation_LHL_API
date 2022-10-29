using Graduation_LHL_API.Entity;

namespace Graduation_LHL_API.IServices
{
    public interface IRegionService
    {
        Task<Boolean> AddRegionAsync(int userid,string RegionName);

        Task<Boolean> HasRegionNameByUserIdAsync(int userid,string RegionName);
        Task<Boolean> DeleteRegionByIdAsync(int regionid);
        
        Task<List<Region>> GetAllRegionByUserIdAsync(int userid);

        Task<Region> FindRegionNameByUserIdAsync(int userid,string RegionName);

        Task<Region> FindTopicAsync(string topic);

        Task<Region> FindRegionIdAsync(int regionid);
          
    } 
}
