using System.Text;

public class Kata {
  public static string BreakCamelCase(string str) {
    var result = new StringBuilder();
    foreach (var ch in str) {
      if(char.IsUpper(ch)) {
        result.Append(' ');
      }
      result.Append(ch);
    }
    return result.ToString();
  }
}