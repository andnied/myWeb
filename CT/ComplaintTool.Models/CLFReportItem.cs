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
    
    public partial class CLFReportItem
    {
        public long CLFItemId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string ActivityType { get; set; }
        public string InfoAcquirer { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseInformation { get; set; }
        public string CommentsProcessor { get; set; }
        public Nullable<System.DateTime> GoodDeliveryDate { get; set; }
        public string PlaceHolder { get; set; }
        public string Brand { get; set; }
        public string Stage { get; set; }
        public string RC { get; set; }
        public string CaseId { get; set; }
        public string ChargebackAmount { get; set; }
        public string MID { get; set; }
        public string PAN { get; set; }
        public string ARN { get; set; }
        public string PlaceHolder2 { get; set; }
        public Nullable<System.DateTime> RefundDate { get; set; }
        public string RefundAmount { get; set; }
        public string RefundCurrency { get; set; }
        public string ItemId { get; set; }
        public string SourceIncoming { get; set; }
        public Nullable<System.DateTime> CLFExpirationDate { get; set; }
        public Nullable<int> CLFReportStatus { get; set; }
        public Nullable<int> CLFReportId { get; set; }
        public Nullable<long> CLFItemIdSource { get; set; }
        public Nullable<System.DateTimeOffset> InsertDate { get; set; }
        public string InsertUser { get; set; }
    
        public virtual CLFReport CLFReport { get; set; }
    }
}
