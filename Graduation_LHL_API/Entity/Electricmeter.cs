using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace Graduation_LHL_API.Entity
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("electricmeter")]
    public class Electricmeter
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
         [SugarColumn(ColumnName="epi"    )]
         public string Epi { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="epo"    )]
         public string Epo { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="eqc"    )]
         public string Eqc { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="eql"    )]
         public string Eql { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ua"    )]
         public string Ua { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ub"    )]
         public string Ub { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="uc"    )]
         public string Uc { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="uab"    )]
         public string Uab { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ubc"    )]
         public string Ubc { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="uca"    )]
         public string Uca { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ia"    )]
         public string Ia { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ib"    )]
         public string Ib { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ic"    )]
         public string Ic { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="pa"    )]
         public string Pa { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="pb"    )]
         public string Pb { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="pc"    )]
         public string Pc { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="p"    )]
         public string P { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="qa"    )]
         public string Qa { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="qb"    )]
         public string Qb { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="qc"    )]
         public string Qc { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="q"    )]
         public string Q { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="sa"    )]
         public string Sa { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="sb"    )]
         public string Sb { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="sc"    )]
         public string Sc { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="s"    )]
         public string S { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="pfa"    )]
         public string Pfa { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="pfb"    )]
         public string Pfb { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="pfc"    )]
         public string Pfc { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="pf"    )]
         public string Pf { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="fr"    )]
         public string Fr { get; set; }
    }
}
