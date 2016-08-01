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
    
    public partial class PREPARE_SCHEME
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PREPARE_SCHEME()
        {
            this.APPLIANCE_LABORATORY = new HashSet<APPLIANCE_LABORATORY>();
            this.FILE_UPLOADER = new HashSet<FILE_UPLOADER>();
            this.PRINTREPORT = new HashSet<PRINTREPORT>();
            this.QUALIFIED_UNQUALIFIED_TEST_ITE = new HashSet<QUALIFIED_UNQUALIFIED_TEST_ITE>();
            this.REPORTCOLLECTION = new HashSet<REPORTCOLLECTION>();
            this.METERING_STANDARD_DEVICE = new HashSet<METERING_STANDARD_DEVICE>();
        }
    
        public string ID { get; set; }
        public string REPORT_CATEGORY { get; set; }
        public string CERTIFICATE_CATEGORY { get; set; }
        public string CNAS { get; set; }
        public string CONTROL_NUMBER { get; set; }
        public string CERTIFICATION_AUTHORITY { get; set; }
        public string QUALIFICATIONS { get; set; }
        public string TEMPERATURE { get; set; }
        public string HUMIDITY { get; set; }
        public string CHECK_PLACE { get; set; }
        public string CHECKERID { get; set; }
        public string DETECTERID { get; set; }
        public string APPROVALID { get; set; }
        public Nullable<System.DateTime> CALIBRATION_DATE { get; set; }
        public string CONCLUSION { get; set; }
        public string CONCLUSION_EXPLAIN { get; set; }
        public Nullable<System.DateTime> VALIDITY_PERIOD { get; set; }
        public string CALIBRATION_INSTRUCTIONS { get; set; }
        public string ACCURACY_GRADE { get; set; }
        public string RATED_FREQUENCY { get; set; }
        public string PULSE_CONSTANT { get; set; }
        public string EXTERNAL_RESITANCE_VALUE { get; set; }
        public string SCHEMEID { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string CREATEPERSON { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public string UPDATEPERSON { get; set; }
        public string AUDITOPINION { get; set; }
        public Nullable<System.DateTime> AUDITTIME { get; set; }
        public string AUDITTEPERSON { get; set; }
        public string ISAGGREY { get; set; }
        public string APPROVAL { get; set; }
        public Nullable<System.DateTime> APPROVALDATE { get; set; }
        public string APPROVALEPERSON { get; set; }
        public string APPROVALISAGGREY { get; set; }
        public string PRINTSTATUS { get; set; }
        public string ISBACK { get; set; }
        public string REPORTNUMBER { get; set; }
        public string REPORTSTATUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPLIANCE_LABORATORY> APPLIANCE_LABORATORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FILE_UPLOADER> FILE_UPLOADER { get; set; }
        public virtual SCHEME SCHEME { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRINTREPORT> PRINTREPORT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUALIFIED_UNQUALIFIED_TEST_ITE> QUALIFIED_UNQUALIFIED_TEST_ITE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REPORTCOLLECTION> REPORTCOLLECTION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<METERING_STANDARD_DEVICE> METERING_STANDARD_DEVICE { get; set; }
    }
}
