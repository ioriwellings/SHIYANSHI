//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Langben.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CROSS_COS
    {
        public string ID { get; set; }
        public string COS { get; set; }
        public string TEST_POINT { get; set; }
        public string TEST_POINT_UNIT { get; set; }
        public string STANDARD_VALUE { get; set; }
        public string STANDARD_VALUE_UNIT { get; set; }
        public string DISPLAY_VALUE { get; set; }
        public string DISPLAY_VALUE_UNIT { get; set; }
        public string UNCERTAINTY_DEGREE { get; set; }
        public string PREPARE_SCHEMEID { get; set; }
        public string CROSS_HEADID { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string CREATEPERSON { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public string UPDATEPERSON { get; set; }
    
        public virtual CROSS_HEAD CROSS_HEAD { get; set; }
    }
}
