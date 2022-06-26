using System;
using System.Collections.Generic;

namespace MarcketV3.Models
{
    public partial class Reciep
    {
        public Reciep()
        {
            Sales = new HashSet<Sale>();
        }

        public int ReciepId { get; set; }
        public long? ReciepNumber { get; set; }
        public int? ReciepProductCount { get; set; }
        public double? ReciepTotalPrice { get; set; }
        public double? RecieppriceTax { get; set; }
        public double? PriceTotalWithTax { get; set; }
        public string? ReciepDate { get; set; }
        public string? ReciepPaymentMethode { get; set; }
        public double? ReciepPaymentPrice { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
