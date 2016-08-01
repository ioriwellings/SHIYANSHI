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
    
    public partial class SCHEME
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SCHEME()
        {
            this.PREPARE_SCHEME = new HashSet<PREPARE_SCHEME>();
            this.SCHEME_RULE = new HashSet<SCHEME_RULE>();
        }
    
        public string ID { get; set; }
        public string NAME { get; set; }
        public string REPORT_CATEGORY { get; set; }
        public string CERTIFICATE_CATEGORY { get; set; }
        public string STATUS { get; set; }
        public string ISPUBLISH { get; set; }
        public string COPYID { get; set; }
        public string UNDERTAKE_LABORATORYID { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string CREATEPERSON { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public string UPDATEPERSON { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PREPARE_SCHEME> PREPARE_SCHEME { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCHEME_RULE> SCHEME_RULE { get; set; }
        public virtual UNDERTAKE_LABORATORY UNDERTAKE_LABORATORY { get; set; }
    }
}
