using static System.Console;
using System.Text;

public static class JadenCase {

  public static string ToJadenCase(this string phrase) {
    WriteLine(phrase);
    string[] words = phrase.Split(' ');
    
    for (int i = 0; i < words.Length; i++) {
      words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1); 
    }
    return string.Join(' ', words);
  }
  
}