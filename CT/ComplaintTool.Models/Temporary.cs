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
    
    public partial class Temporary
    {
        public long TemporaryId { get; set; }
        public string CaseId { get; set; }
        public string OrganizationId { get; set; }
        public Nullable<long> IncomingId { get; set; }
        public Nullable<long> PostTranId { get; set; }
        public Nullable<System.DateTime> BusinessDate { get; set; }
        public string ARN { get; set; }
        public string PANMask { get; set; }
        public string PANHash { get; set; }
        public string BrandName { get; set; }
        public Nullable<decimal> TransactionAmount { get; set; }
        public string TransactionCurrencyCode { get; set; }
        public Nullable<decimal> StageAmount { get; set; }
        public string StageCurrencyCode { get; set; }
        public string MessageType { get; set; }
        public string ReasonCode { get; set; }
        public string MID { get; set; }
        public string SourceCountryCode { get; set; }
        public Nullable<int> ProcessingStatus { get; set; }
        public Nullable<int> CBReportStatus { get; set; }
        public Nullable<System.DateTimeOffset> InsertDate { get; set; }
        public string InsertUser { get; set; }
    }
}
