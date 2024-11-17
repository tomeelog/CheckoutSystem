﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSystem.Interfaces
{
    public interface ICheckout
    {
        void Scan(string item);
        int GetTotalPrice();
    }
}
