using SqlSugar;

namespace Graduation_LHL_API.Entity
{
    [SugarTable("users")]
    public class User
    {
        /// <summary>
        /// 主键 
        ///</summary>
        [SugarColumn(ColumnName = "Id", IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "UserName")]
        public string UserName { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "Email")]
        public string Email { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "EmailConfirme")]
        public byte EmailConfirme { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "PasswordHash")]
        public string PasswordHash { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "SecurityStamp")]
        public string SecurityStamp { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        /// <summary>
        ///  
        ///</summary>
        [SugarColumn(ColumnName = "PhoneNumberConfirmed")]
        public byte PhoneNumberConfirmed { get; set; }
    }
}
