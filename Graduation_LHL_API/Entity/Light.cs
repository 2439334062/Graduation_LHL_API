using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Graduation_LHL_API.Entity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("light")]
    public class Light
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Id" ,IsPrimaryKey = true   )]
         public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ClientId"    )]
         public int? ClientId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Illumination"    )]
         public string Illumination { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="DateTime"    )]
         public DateTime? DateTime { get; set; }
    }
}
