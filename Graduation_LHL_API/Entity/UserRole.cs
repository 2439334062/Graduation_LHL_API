using SqlSugar;

namespace Graduation_LHL_API.Entity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("userroles")]
    public class Userrole
    {
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "UserId", IsPrimaryKey = true)]
        public int UserId { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "RoleId", IsPrimaryKey = true)]
        public int RoleId { get; set; }
    }
}
