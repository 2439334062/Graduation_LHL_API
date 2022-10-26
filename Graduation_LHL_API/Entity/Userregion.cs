using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Graduation_LHL_API.Entity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("userregion")]
    public class Userregion
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="UserId" ,IsPrimaryKey = true   )]
         public int UserId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="RegionId" ,IsPrimaryKey = true   )]
         public int RegionId { get; set; }
    }
}
