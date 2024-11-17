using CheckoutSystem.Interfaces;
using CheckoutSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSystem.Services
{
    public class Checkout : ICheckout
    {
        private readonly Dictionary<string, int> _items = new();
        private readonly Dictionary<string, PricingRule> _pricingRules;

        public Checkout(Dictionary<string, PricingRule> pricingRules)
        {
            _pricingRules = pricingRules;
        }
        public void Scan(string item)
        {
            if (_items.ContainsKey(item))
                _items[item]++;
            else
                _items[item] = 1;
        }

        public int GetTotalPrice()
        {
            int totalPrice = 0;

            foreach (var item in _items)
            {
                if (_pricingRules.ContainsKey(item.Key))
                {
                    var pricingRule = _pricingRules[item.Key];
                    int quantity = item.Value;

                    if (pricingRule.SpecialQuantity > 0 && quantity >= pricingRule.SpecialQuantity)
                    {
                        totalPrice += (quantity / pricingRule.SpecialQuantity) * pricingRule.SpecialPrice;
                        quantity %= pricingRule.SpecialQuantity;
                    }

                    totalPrice += quantity * pricingRule.UnitPrice;
                }
            }

            return totalPrice;
        }
    }
}
