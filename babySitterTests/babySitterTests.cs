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
      var family = new Family(15, 20, 11);
      Assert.Equal(15, sitter.CalculatePay(family, 5, 6));
    }
    [Fact]
    public void sitterIsPaidForTwoHours()
    {
      var sitter = new Sitter();
      var family = new Family(15, 20, 11);
      Assert.Equal(30, sitter.CalculatePay(family, 5, 7));
    }
    [Fact]
    public void sitterIsPaidCorrectWagePerFamilyAndHoursWorked()
    {
      var sitter = new Sitter();
      var family = new Family(15, 20, 11);
      Assert.Equal(60, sitter.CalculatePay(family, 5, 9));
    }
    [Fact]
    public void sitterisPaidCorrectWagePerFamilyAndHoursWorkedAfterCutoffTime()
    {
      var sitter = new Sitter();
      var family = new Family(15, 20, 10);

      Assert.Equal(40, sitter.CalculatePay(family, 10, 12));
    }
  }
}
