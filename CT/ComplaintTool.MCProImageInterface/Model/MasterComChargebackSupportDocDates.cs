﻿using System.Xml.Serialization;

namespace ComplaintTool.MCProImageInterface.Model
{
    [XmlType]
    public class MasterComChargebackSupportDocDates
    {
        [XmlElement(Order = 1, ElementName = "s1")]
        public string S1MasterComChargebackSupportDocumentationSenderProcessingDate { get; set; }

        [XmlElement(Order = 2, ElementName = "s2")]
        public string S2MasterComChargebackSupportDocumentationSenderProcessingDate { get; set; }
    }
}
