//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SantiyeYönetim
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_ProjectAssignments
    {
        public int AssignmentID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public Nullable<System.DateTime> AssignedDate { get; set; }
    
        public virtual Tbl_Employees Tbl_Employees { get; set; }
        public virtual Tbl_Projects Tbl_Projects { get; set; }
    }
}
