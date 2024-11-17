using CheckoutSystem.Interfaces;
using CheckoutSystem.Models;
using CheckoutSystem.Services;
using CheckoutSystem.Test.DataFactory;
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
            ICheckout checkout = new Checkout(PricingRuleFactory.GetPricingRules());
            Assert.AreEqual(0, checkout.GetTotalPrice());
        }

        [Test]
        public void Scan_SingleItemA_ReturnsCorrectPrice()
        {
            ICheckout checkout = new Checkout(PricingRuleFactory.GetPricingRules());
            checkout.Scan("A");
            Assert.AreEqual(50, checkout.GetTotalPrice());
        }

        [Test]
        public void Scan_ThreeItemsWithSpecialPrice_ReturnsDiscountedPrice()
        {
            ICheckout checkout = new Checkout(PricingRuleFactory.GetPricingRules());
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            Assert.AreEqual(130, checkout.GetTotalPrice());
        }
    }
}
