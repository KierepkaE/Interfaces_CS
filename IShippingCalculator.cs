using System;

namespace interfaces {
  public interface IShippingCalculator {
    float CalculateShipping (Order order);
  }
}