using System.Text.RegularExpressions;

namespace Kata {

  public static class Problem {
    
    public static string CamelCase(this string str) {
      string[] words = Regex.Split(str, @"\s+");
      string newString = "";
      foreach (string match in words) {
         if (Regex.IsMatch(match, @"^[a-zA-Z]+$")) {
           newString += match.Substring(0, 1).ToUpper() + match.Substring(1).ToLower();
         }
      }
      return newString;
    }
    
  }
  
}

