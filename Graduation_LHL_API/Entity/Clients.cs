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
         public Guid ClientName { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName= "ConnPassword")]
         public string ConnPassword { get; set; }

        [SugarColumn(ColumnName = "ConnName")]
        public string ConnName { get; set; }
    }
}
