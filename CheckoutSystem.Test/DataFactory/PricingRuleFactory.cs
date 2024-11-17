using CheckoutSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSystem.Test.DataFactory
{
    public static class PricingRuleFactory
    {
        public static Dictionary<string, PricingRule> GetPricingRules()
        {
            return new Dictionary<string, PricingRule>
            {
                { "A", new PricingRule(50, 3, 130) },
                { "B", new PricingRule(30, 2, 45) },
                { "C", new PricingRule(20) },
                { "D", new PricingRule(15) }
            };
        }
    }
}
