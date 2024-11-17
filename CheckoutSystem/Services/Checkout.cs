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
        
        public void Scan(string item)
        {
           
        }

        public int GetTotalPrice()
        {
            return 0;
        }
    }
}
