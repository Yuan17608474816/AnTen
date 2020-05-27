//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patients()
        {
            this.Audit = new HashSet<Audit>();
            this.InterRecord = new HashSet<InterRecord>();
            this.MedRecordes = new HashSet<MedRecordes>();
        }
    
        public int PID { get; set; }
        public string P_Name { get; set; }
        public string P_Account { get; set; }
        public int P_RegType { get; set; }
        public string P_Password { get; set; }
        public int P_Sex { get; set; }
        public string P_Phone { get; set; }
        public string P_IdNum { get; set; }
        public System.DateTime P_Birthday { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Audit> Audit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InterRecord> InterRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedRecordes> MedRecordes { get; set; }
    }
}
