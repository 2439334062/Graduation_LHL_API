using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Graduation_LHL_API.Entity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("temphum")]
    public class Temphum
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true   )]
         public Guid Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ClientId"    )]
         public int? ClientId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Temperature"    )]
         public string Temperature { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Humidity"    )]
         public string Humidity { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="DateTime"    )]
         public DateTime? DateTime { get; set; }
    }
}
