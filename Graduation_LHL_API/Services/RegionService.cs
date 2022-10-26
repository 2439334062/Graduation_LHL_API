using Graduation_LHL_API.Database;
using Graduation_LHL_API.Entity;
using Graduation_LHL_API.IServices;

namespace Graduation_LHL_API.Services
{

    public class RegionService : IRegionService
    {
        public async Task<Boolean> AddRegionAsync(int userid, string RegionName)
        {
            Region regoin = new Region()
            {
                RegionName = RegionName,
                Topic = Guid.NewGuid().ToString(),
                DateTime = DateTime.Now
            };

            var id= await SqlSugarHelper.Db.Insertable(regoin).ExecuteReturnIdentityAsync();
            var result = await SqlSugarHelper.Db.Insertable(new Userregion() { RegionId = id, UserId = userid }).ExecuteCommandAsync();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> HasRegionNameByUserIdAsync(int userid, string RegionName)
        {
            return await SqlSugarHelper.Db.Queryable<Region, Userregion>((r, u) => r.Id == u.RegionId)
                .Where((r, u) => u.UserId == userid)
                .Select((r,u)=>new {Id=r.Id,UserId=u.UserId,RegionName=r.RegionName})
                .ToListAsync() !=null;
            
        }
    }
}
