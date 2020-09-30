using System;

public class CodeWars {
  public static bool IsDigit(string s) {
    double number;
    return Double.TryParse(s, out number);
  }
}