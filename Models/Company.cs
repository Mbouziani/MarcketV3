using System;
using System.Collections.Generic;

namespace MarcketV3.Models
{
    public partial class Company
    {
        public int CompanyId { get; set; }
        public long? CompanyNumber { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyAddress { get; set; }
        public string? CompanyTaxNumber { get; set; }
        public string? CompanyPhone { get; set; }
        public string? CompanyCommercial { get; set; }
        public string? CompanyMobile { get; set; }
    }
}
