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
    
    public partial class FeeConfiguration
    {
        public long FeeConfigurationId { get; set; }
        public string CountryCode { get; set; }
        public int FeeTypeId { get; set; }
        public string OrganizationId { get; set; }
        public string Attribute { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public System.DateTimeOffset InsertDate { get; set; }
        public string InsertUser { get; set; }
    }
}
