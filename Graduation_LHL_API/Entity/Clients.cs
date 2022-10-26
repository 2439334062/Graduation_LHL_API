using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Graduation_LHL_API.Entity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("clients")]
    public class Clients
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ClientName"    )]
         public string ClientName { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ClientPassword"    )]
         public string ClientPassword { get; set; }
    }
}
