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
    
    public partial class RepresentmentExtractDocument
    {
        public long RepresentmentExtractDocumentId { get; set; }
        public string CaseId { get; set; }
        public long RepresentmentDocumentsId { get; set; }
        public long DocumentId { get; set; }
        public Nullable<System.Guid> XML_stream_id { get; set; }
        public Nullable<System.Guid> TIF_stream_id { get; set; }
        public Nullable<System.Guid> PDF_stream_id { get; set; }
        public Nullable<System.Guid> Extract_stream_id { get; set; }
        public int ExportStatus { get; set; }
        public Nullable<System.DateTimeOffset> ExportDate { get; set; }
        public string ExportUser { get; set; }
        public string FileNameWithPath { get; set; }
        public bool ErrorFlag { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTimeOffset> InsertDate { get; set; }
        public string InsertUser { get; set; }
    
        public virtual RepresentmentDocument RepresentmentDocument { get; set; }
    }
}
