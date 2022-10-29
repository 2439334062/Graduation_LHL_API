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

        public async Task<bool> DeleteRegionByIdAsync(int regionid)
        {
            var result = await SqlSugarHelper.Db.Deleteable<Region>().In(regionid).ExecuteCommandAsync();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<Region> FindRegionIdAsync(int regionid)
        {
            var result = await SqlSugarHelper.Db.Queryable<Region>().In(regionid).ToListAsync();
            return result[0];
        }

        public async Task<Region> FindRegionNameByUserIdAsync(int userid, string RegionName)
        {
            return await SqlSugarHelper.Db.Queryable<Region, Userregion>((r, u) => r.Id == u.RegionId)
                .Where((r, u) => u.UserId == userid && r.RegionName == RegionName).FirstAsync();
        }

        public async Task<Region> FindTopicAsync(string topic)
        {
            return await SqlSugarHelper.Db.Queryable<Region>().Where(r => r.Topic == topic).FirstAsync();
        }

        public async Task<List<Region>> GetAllRegionByUserIdAsync(int userid)
        {
            var result = await SqlSugarHelper.Db.Queryable<Region,Userregion>((r, u) => r.Id == u.RegionId).Where((r, u) => u.UserId==userid).ToListAsync();
            return result;
        }

        public async Task<bool> HasRegionNameByUserIdAsync(int userid, string RegionName)
        {
            return await SqlSugarHelper.Db.Queryable<Region, Userregion>((r, u) => r.Id == u.RegionId)
                .Where((r, u) => u.UserId == userid && r.RegionName ==RegionName).AnyAsync();
            
        }
    }
}
