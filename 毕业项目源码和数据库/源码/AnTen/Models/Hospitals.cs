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
    
    public partial class Hospitals
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hospitals()
        {
            this.Adm_Offs = new HashSet<Adm_Offs>();
            this.HosEquipments = new HashSet<HosEquipments>();
            this.InterRecord = new HashSet<InterRecord>();
            this.MedRecordes = new HashSet<MedRecordes>();
            this.ProQualif = new HashSet<ProQualif>();
        }
    
        public int HID { get; set; }
        public int ProID { get; set; }
        public int CityID { get; set; }
        public int CouID { get; set; }
        public string H_Name { get; set; }
        public Nullable<int> H_rate { get; set; }
        public string H_Remark { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adm_Offs> Adm_Offs { get; set; }
        public virtual City City { get; set; }
        public virtual County County { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HosEquipments> HosEquipments { get; set; }
        public virtual Province Province { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InterRecord> InterRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedRecordes> MedRecordes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProQualif> ProQualif { get; set; }
    }
}
