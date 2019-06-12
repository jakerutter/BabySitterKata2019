using System;
using System.Collections.Generic;
using System.Text;

namespace BabysittingCalculator
{
  public class Family
  {
    private int earlyPrice;
    private int latePrice;
    private int cutoffTime;
    public int EarlyPrice
    {
      get { return earlyPrice; }
    }

    public int LatePrice
    {
      get { return latePrice; }
    }
    public int CutoffTime
    {
      get { return cutoffTime; }
    }

    public Family(int earlyPrice, int latePrice, int cutoffTime)
    {
      this.earlyPrice = earlyPrice;
      this.latePrice = latePrice;
      this.cutoffTime = cutoffTime;
    }
  }
}
