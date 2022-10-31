using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Graduation_LHL_API.Entity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("ClientDeviceType")]
    public class ClientDeviceType
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="id" ,IsPrimaryKey = true ,IsIdentity = true  )]
         public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ClientId"    )]
         public int? ClientId { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="typeId"    )]
         public int? TypeId { get; set; }
    }
}
