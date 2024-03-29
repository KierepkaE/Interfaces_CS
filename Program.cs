﻿using System;

namespace interfaces {
    class Program {
        static void Main (string[] args) {
            var orderProcessor = new OrderProcessor (IShippingCalculator ());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process (order);
        }
    }
}