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
    
    public partial class VisitTime
    {
        public int VTID { get; set; }
        public int HDID { get; set; }
        public int VT_Time { get; set; }
        public int DateVisit { get; set; }
    
        public virtual HosDoctors HosDoctors { get; set; }
    }
}
