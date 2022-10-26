using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Graduation_LHL_API.Entity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("atm")]
    public class Atm
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Id" ,IsPrimaryKey = true   )]
         public Guid Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ClientId"    )]
         public int? ClientId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="atmValue"    )]
         public string AtmValue { get; set; }
    }
}
