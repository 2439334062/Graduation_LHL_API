using Graduation_LHL_API.Database;
using Graduation_LHL_API.Entity;
using Graduation_LHL_API.IServices;
using Graduation_LHL_API.Utils;

namespace Graduation_LHL_API.Services
{
    public class UserService : IUserService
    {
        public async Task<bool> CreateAsync(User user, string password)
        {
            user.EmailConfirme = 0;
            user.PhoneNumberConfirmed = 0;

            user.PasswordHash = HashEncode.ApplyHash256(password.Trim());//加密
            user.SecurityStamp= Guid.NewGuid().ToString();

            int result = await SqlSugarHelper.Db.Insertable(user).ExecuteCommandAsync();
            if (result > 0)
            {
                return true;
            }
            return false;            
        }
        /// <summary>
        /// 查找对应姓名
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<User> FindByEmailAsync(string  Email)
        {
            var result = await SqlSugarHelper.Db.Queryable<User>().Where(u => u.Email == Email).ToListAsync();
     
            return result.FirstOrDefault();            

        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            password = HashEncode.ApplyHash256(password.Trim());// 加密
            var result = await SqlSugarHelper.Db.Queryable<User>().Where(u => u.UserName == username && u.PasswordHash == password).CountAsync();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public Task<bool> UpdateAsync(User user, string password)
        {
            throw new NotImplementedException();
        }
    }
}
