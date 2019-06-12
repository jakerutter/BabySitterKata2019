using System;

namespace BabysittingCalculator
{
  public class Sitter
  {
    public int CalculatePay(int hoursWorked, int hourlyRate)
    {
      int amountToPay;

      amountToPay = hoursWorked * hourlyRate;

      return amountToPay;
    }
  }
}
