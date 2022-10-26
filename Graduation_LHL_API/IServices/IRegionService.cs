namespace Graduation_LHL_API.IServices
{
    public interface IRegionService
    {
        Task<Boolean> AddRegionAsync(int userid,string RegionName);

        Task<Boolean> HasRegionNameByUserIdAsync(int userid,string RegionName);
    }
}
