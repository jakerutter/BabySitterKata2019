using System;

namespace BabysittingCalculator
{
  public class Sitter
  {
    public int CalculatePay(Family fam, int startTime, int endTime)
    {
      int amountPaid = 0;
      int earlyHoursWorked = 0;
      int lateHoursWorked = 0;

      //calculate hours if babysitter worked during first time interval
      if (startTime < fam.CutoffTime)
      {
        if (endTime > fam.CutoffTime)
        {
          earlyHoursWorked = fam.CutoffTime - startTime;
        }
        else
        {
          earlyHoursWorked = endTime - startTime;
        }
      }

      if (endTime > fam.CutoffTime)
      {
        if (startTime < fam.CutoffTime)
        {
          lateHoursWorked = endTime - fam.CutoffTime;
        }
        else
        {
          lateHoursWorked = endTime - startTime;
        }
      }

      return earlyHoursWorked * fam.EarlyPrice + lateHoursWorked * fam.LatePrice;
    }
  }
}
