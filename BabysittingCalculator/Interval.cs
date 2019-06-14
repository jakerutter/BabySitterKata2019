using System;
using System.Collections.Generic;
using System.Text;

namespace BabysittingCalculator
{
  public class Interval
  {
    private int startInterval;
    private int endInterval;
    private int payRate;

    public int StartInterval
    {
      get { return startInterval; }
    }
    public int EndInterval
    {
      get { return endInterval; }
    }
    public int PayRate
    {
      get { return payRate; }
    }

    public Interval(int startInterval, int endInterval, int payRate)
    {
      this.startInterval = startInterval;
      this.endInterval = endInterval;
      this.payRate = payRate;
    }

  }
}
