//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComplaintTool.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ComplaintSuspended
    {
        public int SuspendedId { get; set; }
        public string CaseId { get; set; }
        public System.DateTimeOffset SuspendedDate { get; set; }
        public int SuspendedDay { get; set; }
        public System.DateTimeOffset SuspendedEndDate { get; set; }
        public Nullable<System.DateTimeOffset> InsertDate { get; set; }
        public string InsertUser { get; set; }
    
        public virtual Complaint Complaint { get; set; }
    }
}
