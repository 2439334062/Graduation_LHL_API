using SqlSugar;

namespace Graduation_LHL_API.Entity
{
    [SugarTable("userroles")]
    public class UserRole
    {
        [SugarColumn(IsPrimaryKey = true)]
        public int UserId { get; set; }
        [SugarColumn(IsPrimaryKey = true)]
        public int RoleId { get; set; }
    }
}
