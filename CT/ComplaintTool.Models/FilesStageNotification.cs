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
    
    public partial class FilesStageNotification
    {
        public long NotificationId { get; set; }
        public string OrganizationId { get; set; }
        public string CaseId { get; set; }
        public long StageId { get; set; }
        public string FileDescription { get; set; }
        public Nullable<long> AuditId { get; set; }
        public Nullable<long> IncomingId { get; set; }
        public Nullable<long> OutgoingId { get; set; }
        public System.DateTime NoteDate { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTimeOffset> InsertDate { get; set; }
        public string InsertUser { get; set; }
    
        public virtual Complaint Complaint { get; set; }
        public virtual Complaint Complaint1 { get; set; }
        public virtual ComplaintStage ComplaintStage { get; set; }
        public virtual Audit Audit { get; set; }
        public virtual CaseFilingIncomingFile CaseFilingIncomingFile { get; set; }
        public virtual CaseFilingOutgoingFile CaseFilingOutgoingFile { get; set; }
    }
}
