using System;
using System.Collections.Generic;

namespace MarcketV3.Models
{
    public partial class SaleZone
    {
        public int SaleZoneId { get; set; }
        public long? SaleZoneNumber { get; set; }
        public string? SaleZoneName { get; set; }
        public string? SaleZoneDirector { get; set; }
        public string? SaleZoneAddress { get; set; }
        public string? SaleZonePhone { get; set; }
    }
}
