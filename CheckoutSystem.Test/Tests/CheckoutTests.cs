﻿using CheckoutSystem.Interfaces;
using CheckoutSystem.Models;
using CheckoutSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSystem.Test.Tests
{
    [TestFixture]
    public class CheckoutTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetTotalPrice_NoItemsScanned_ReturnsZero()
        {
            var pricingRules = new Dictionary<string, PricingRule>();
            ICheckout checkout = new Checkout(pricingRules);
            Assert.AreEqual(0, checkout.GetTotalPrice());
        }

        [Test]
        public void Scan_SingleItemA_ReturnsCorrectPrice()
        {
            var pricingRules = new Dictionary<string, PricingRule>
            {
                { "A", new PricingRule(50) }
            };
            ICheckout checkout = new Checkout(pricingRules);
            checkout.Scan("A");
            Assert.AreEqual(50, checkout.GetTotalPrice());
        }

        [Test]
        public void Scan_ThreeItemsWithSpecialPrice_ReturnsDiscountedPrice()
        {
            var pricingRules = new Dictionary<string, PricingRule>
            {
                { "A", new PricingRule(50, 3, 130) }
            };

            ICheckout checkout = new Checkout(pricingRules);
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            Assert.AreEqual(130, checkout.GetTotalPrice());
        }
    }
}
