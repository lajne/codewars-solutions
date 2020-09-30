using System;

public class Kata {
  public static double NbaExtrap(double ppg, double mpg) {
    return mpg > 0 ? Math.Round(ppg/mpg*48, 1) : 0;
  }
}