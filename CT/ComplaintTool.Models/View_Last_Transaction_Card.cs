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
    
    public partial class View_Last_Transaction_Card
    {
        public string pan_reference { get; set; }
        public string expiry_date { get; set; }
        public System.DateTime datetime_req { get; set; }
        public decimal requested_amount { get; set; }
        public string currency_code { get; set; }
        public string terminal_id { get; set; }
        public string response_code { get; set; }
        public long tran_nr { get; set; }
    }
}
