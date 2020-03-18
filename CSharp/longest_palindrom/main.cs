using System;

public class Kata {

  public static int GetLongestPalindrome(string str) {
    if (String.IsNullOrEmpty(str))
      return 0;
    if (str.Length == 1)
      return 1;

    int longest = 0;
    
    for(int i = 0; i < str.Length; i++){
      for(int j = i + 1; j <= str.Length; j++) {
        string chunk = str.Substring(i, j - i);
        int len = chunk.Length;
        if (IsPalindrom(chunk) && longest < len) {
          longest = len;
        }
      }
    }

    return longest;
  }
  
  public static bool IsPalindrom(string str) {
		var strArray = str.ToCharArray();
		Array.Reverse(strArray);
				
		return (new string(strArray)).Equals(str); 
	}
  
}