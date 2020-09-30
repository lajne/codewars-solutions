using System;
using System.Text.RegularExpressions;

public class Kata {
  public static bool ValidateCode(string code)  {
      return Regex.IsMatch(code, @"^[1-3]");
  }
}