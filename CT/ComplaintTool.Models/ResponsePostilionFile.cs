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
    
    public partial class ResponsePostilionFile
    {
        public long ResponsePostilionFileId { get; set; }
        public string FileName { get; set; }
        public Nullable<System.Guid> stream_id { get; set; }
        public Nullable<System.DateTimeOffset> ProcesingStart { get; set; }
        public Nullable<System.DateTimeOffset> ProcesingFinished { get; set; }
        public Nullable<bool> IsSend { get; set; }
        public Nullable<bool> IsReceived { get; set; }
        public Nullable<bool> ErrorFlag { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTimeOffset> InsertDate { get; set; }
        public string InsertUser { get; set; }
    }
}
