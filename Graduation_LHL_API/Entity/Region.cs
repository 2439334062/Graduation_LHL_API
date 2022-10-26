using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Graduation_LHL_API.Entity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("region")]
    public class Region
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="RegionName"    )]
         public string RegionName { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Topic"    )]
         public string Topic { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="DateTime"    )]
         public DateTime DateTime { get; set; }
    }
}
