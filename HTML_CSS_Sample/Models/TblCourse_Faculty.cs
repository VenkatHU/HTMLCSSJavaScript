//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HTML_CSS_Sample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblCourse_Faculty
    {
        public int CourseFaultyID { get; set; }
        public Nullable<int> CourseId { get; set; }
        public Nullable<int> StaffID { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
