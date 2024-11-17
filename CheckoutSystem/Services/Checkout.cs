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
                totalPrice += _pricingRules[item.Key].UnitPrice * item.Value;
            }
            return totalPrice;
        }
    }
}
