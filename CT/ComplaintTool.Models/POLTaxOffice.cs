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
    
    public partial class POLTaxOffice
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public string HouseNo { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string PostOffice { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public string EmailAddress { get; set; }
        public bool IsActive { get; set; }
        public System.DateTimeOffset InsertDate { get; set; }
        public string InsertUser { get; set; }
    }
}