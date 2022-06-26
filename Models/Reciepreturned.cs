using System;
using System.Collections.Generic;

namespace MarcketV3.Models
{
    public partial class Reciepreturned
    {
        public Reciepreturned()
        {
            Salereturneds = new HashSet<Salereturned>();
        }

        public int ReciepId { get; set; }
        public long? ReciepNumber { get; set; }
        public int? ReciepProductCount { get; set; }
        public double? ReciepTotalPrice { get; set; }
        public double? RecieppriceTax { get; set; }
        public double? PriceTotalWithTax { get; set; }
        public string? ReciepDate { get; set; }
        public string? ReturnedDate { get; set; }
        public string? Reciepdescriptio { get; set; }

        public virtual ICollection<Salereturned> Salereturneds { get; set; }
    }
}
