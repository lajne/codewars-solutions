using System.Text;

public class Kata {

  public static string Vowels = "aouei";

  public static string Shortcut(string input) {
    var result = new StringBuilder();
    for (int i = 0; i < input.Length; i++) {
      if (!Vowels.Contains(input[i]))
        result.Append(input[i]);
    }
    
    return result.ToString();
  }
}