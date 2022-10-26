using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Graduation_LHL_API.Entity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("regionclient")]
    public class Regionclient
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="RegionId" ,IsPrimaryKey = true   )]
         public int RegionId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ClientId" ,IsPrimaryKey = true   )]
         public int ClientId { get; set; }
    }
}
