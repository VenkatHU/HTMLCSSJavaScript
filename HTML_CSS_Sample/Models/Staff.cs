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
    
    public partial class Staff
    {
        public Staff()
        {
            this.TblCourse_Faculty = new HashSet<TblCourse_Faculty>();
        }
    
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    
        public virtual ICollection<TblCourse_Faculty> TblCourse_Faculty { get; set; }
    }
}
