using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSystem.Models
{
    public class PricingRule
    {
        public int UnitPrice { get; set; }
        public int SpecialQuantity { get; set; }
        public int SpecialPrice { get; set; }

        public PricingRule(int unitPrice, int specialQuantity = 0, int specialPrice = 0)
        {
            UnitPrice = unitPrice;
            SpecialQuantity = specialQuantity;
            SpecialPrice = specialPrice;
        }
    }
}
