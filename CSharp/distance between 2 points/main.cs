using System;

public class Kata {
  public static double DistanceBetweenPoints(Point a, Point b) {
    return (Math.Sqrt(Math.Pow(Math.Abs(a.X - b.X), 2) + Math.Pow(Math.Abs(a.Y - b.Y), 2)));
  }
}