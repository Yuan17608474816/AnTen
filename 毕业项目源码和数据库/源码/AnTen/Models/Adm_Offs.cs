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
    
    public partial class Adm_Offs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adm_Offs()
        {
            this.HosDoctors = new HashSet<HosDoctors>();
            this.MedRecordes = new HashSet<MedRecordes>();
            this.OutPatientDep = new HashSet<OutPatientDep>();
        }
    
        public int AOID { get; set; }
        public int HID { get; set; }
        public string AO_Name { get; set; }
        public string AO_Location { get; set; }
        public string AO_Remark { get; set; }
    
        public virtual Hospitals Hospitals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HosDoctors> HosDoctors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedRecordes> MedRecordes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutPatientDep> OutPatientDep { get; set; }
    }
}
