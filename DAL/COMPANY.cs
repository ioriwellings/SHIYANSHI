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
    
    public partial class COMPANY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPANY()
        {
            this.COMPANY1 = new HashSet<COMPANY>();
        }
    
        public string ID { get; set; }
        public string COMPANYNAME { get; set; }
        public string COMPANYADDRES { get; set; }
        public string POSTCODE { get; set; }
        public string CONTACTS { get; set; }
        public string CONTACTSNUMBER { get; set; }
        public string FAX { get; set; }
        public string PARENTID { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string CREATEPERSON { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public string UPDATEPERSON { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPANY> COMPANY1 { get; set; }
        public virtual COMPANY COMPANY2 { get; set; }
    }
}
