using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Queen.Models
{
  public class Chess
  {
    public static bool CompareCoordinates(int queenX, int queenY, int otherX, int otherY)
    {
      if ((queenX - otherX) == (queenY - otherY))
      {
        return true;
      }
      else if (queenX == otherX)
      {
        return true;
      }
      else if (queenY == otherY)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
