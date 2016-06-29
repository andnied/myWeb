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
    
    public partial class GoodFaithLetterValue
    {
        public long ValueId { get; set; }
        public string CaseId { get; set; }
        public long StageId { get; set; }
        public Nullable<decimal> FeeAmount { get; set; }
        public string FeeCurrencyCode { get; set; }
        public Nullable<decimal> FeeExchangedAmount { get; set; }
        public string FeeExchangedCurrencyCode { get; set; }
        public Nullable<decimal> ExchangeRate { get; set; }
        public Nullable<System.DateTime> ExchangeDate { get; set; }
        public System.DateTimeOffset InsertDate { get; set; }
        public string InsertUser { get; set; }
    
        public virtual GoodFaithLetter GoodFaithLetter { get; set; }
        public virtual GoodFaithLetterStage GoodFaithLetterStage { get; set; }
    }
}
