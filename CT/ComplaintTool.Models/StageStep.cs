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
    
    public partial class StageStep
    {
        public int StageStep1 { get; set; }
        public string OrganizationId { get; set; }
        public string BaseStage { get; set; }
        public string BaseStageDescription { get; set; }
        public string NextStage { get; set; }
        public string NextStageDescription { get; set; }
        public bool IsFinalStage { get; set; }
    }
}
