using System;
using static System.Console;

public class Kata {
  public static int CloseCompare(double a, double b, double margin = 0) {
    if (margin != 0) {
      if (Math.Abs(a - b) <= margin)
        return 0;
    }
    if (a < b)
      return -1;
    if (a > b)
      return 1;
    return 0;
  }
}