// Complete the solution so that it splits the string into pairs of two characters. If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

// Examples:

// SplitString.Solution("abc"); // should return ["ab", "c_"]
// SplitString.Solution("abcdef"); // should return ["ab", "cd", "ef"]

public class SplitString {
  public static string[] Solution(string str) {
    string[] arr = new string[(str.Length + 1) / 2];
    int index = 0;
    
    for(int i = 0; i < str.Length; i++) {
      if(str.Length < i + 2) {
        arr[index] = str[i] + "_";
      } else {
        arr[index] = str.Substring(i, 2);
      }
      i += 1;
      index++;
    }
    return arr;
  }
}