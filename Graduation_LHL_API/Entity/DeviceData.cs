using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Graduation_LHL_API.Entity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("DeviceData")]
    public class DeviceData
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true   )]
         public Guid Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="typeid"    )]
         public int? Typeid { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Content"    )]
         public string Content { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="DateTime"    )]
         public DateTime? DateTime { get; set; }
    }
}
