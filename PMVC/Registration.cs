//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registration
    {
        public int RegistrationID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public System.DateTime EnrollmentDate { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
