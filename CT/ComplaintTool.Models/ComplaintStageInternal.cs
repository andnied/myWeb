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
    
    public partial class ComplaintStageInternal
    {
        public long StageInternalId { get; set; }
        public long StageId { get; set; }
        public long InternalStageId { get; set; }
        public string InternalStageCode { get; set; }
        public string MemberMessageText { get; set; }
        public bool IsPartial { get; set; }
        public System.DateTimeOffset StatusDate { get; set; }
        public System.DateTimeOffset InsertDate { get; set; }
        public string InsertUser { get; set; }
    
        public virtual ComplaintStage ComplaintStage { get; set; }
        public virtual InternalStageDefinition InternalStageDefinition { get; set; }
    }
}
