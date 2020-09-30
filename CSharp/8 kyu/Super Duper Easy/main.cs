using System;

public class Kata {
  public static string Problem(String a) {
    return (Double.TryParse(a, out double num)) ? ((Double.Parse(a) * 50) + 6).ToString() : "Error";
  }
}