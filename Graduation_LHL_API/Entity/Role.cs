using SqlSugar;

namespace Graduation_LHL_API.Entity
{

    [SugarTable("roles")]
    public class Role
    {
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "Id", IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "Name")]
        public string Name { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "ConcurrencyStamp")]
        public string ConcurrencyStamp { get; set; }
    }
}
