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
    
    public partial class RepresentmentCondition
    {
        public int ConditionsId { get; set; }
        public string OrganizationId { get; set; }
        public bool IsAutomatic { get; set; }
        public bool Is3DSecure { get; set; }
        public string SourceStageCode { get; set; }
        public string SourceReasonCode { get; set; }
        public int DayStep { get; set; }
        public string DestinationStageCode { get; set; }
        public string DestinationReasonCode { get; set; }
        public bool DocumentationIndicator { get; set; }
        public int MessageId { get; set; }
        public System.DateTimeOffset InsertDate { get; set; }
        public string InsertUser { get; set; }
    }
}
