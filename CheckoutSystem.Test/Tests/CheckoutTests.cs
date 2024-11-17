using CheckoutSystem.Interfaces;
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
            ICheckout checkout = new Checkout();
            Assert.AreEqual(0, checkout.GetTotalPrice());
        }
    }
}
