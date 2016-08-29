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
    
    public partial class RULE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RULE()
        {
            this.UNCERTAINTY = new HashSet<UNCERTAINTY>();
            this.RULE1 = new HashSet<RULE>();
            this.SCHEME_RULE = new HashSet<SCHEME_RULE>();
            this.THREE_PHASE_UNCERTAINTY = new HashSet<THREE_PHASE_UNCERTAINTY>();
            this.UNCERTAINTYPARAMETERMANAGEMENT = new HashSet<UNCERTAINTYPARAMETERMANAGEMENT>();
            this.UNCERTAINTY2_HZ = new HashSet<UNCERTAINTY2_HZ>();
        }
    
        public string ID { get; set; }
        public string NAME { get; set; }
        public string SCHEME_MENU { get; set; }
        public Nullable<decimal> SORT { get; set; }
        public string IS_UNCERTAINTY { get; set; }
        public string UNCERTAINTY_MENU { get; set; }
        public string UNDERTAKE_LABORATORYID { get; set; }
        public string INPUTSTATE { get; set; }
        public string PARENTID { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string CREATEPERSON { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public string UPDATEPERSON { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNCERTAINTY> UNCERTAINTY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RULE> RULE1 { get; set; }
        public virtual RULE RULE2 { get; set; }
        public virtual UNDERTAKE_LABORATORY UNDERTAKE_LABORATORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCHEME_RULE> SCHEME_RULE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THREE_PHASE_UNCERTAINTY> THREE_PHASE_UNCERTAINTY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNCERTAINTYPARAMETERMANAGEMENT> UNCERTAINTYPARAMETERMANAGEMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNCERTAINTY2_HZ> UNCERTAINTY2_HZ { get; set; }
    }
}
