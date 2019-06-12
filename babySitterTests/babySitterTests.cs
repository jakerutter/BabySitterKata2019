using System;
using Xunit;
using BabysittingCalculator;

namespace babySitterTests
{
  public class babySitterTest
  {
    [Fact]
    public void sitterIsPaidForOneHour()
    {
      var sitter = new Sitter();
      Assert.Equal(15, sitter.CalculatePay(1, 15));
    }
    [Fact]
    public void sitterIsPaidForTwoHours()
    {
      var sitter = new Sitter();
      Assert.Equal(30, sitter.CalculatePay(2, 15));
    }
  }
}
