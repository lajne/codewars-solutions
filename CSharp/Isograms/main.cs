// An isogram is a word that has no repeating letters, consecutive or non-consecutive. 
// Implement a function that determines whether a string that contains only letters is an isogram. 
// Assume the empty string is an isogram. Ignore letter case.

// isIsogram "Dermatoglyphics" == true
// isIsogram "aba" == false
// isIsogram "moOse" == false -- ignore letter case

public class Kata {
  public static bool IsIsogram(string str) {
    char[] strChars = str.ToLower().ToCharArray();
    Array.Sort(strChars);
    int i = 0;
    bool isIsogram = true;
    
    while (isIsogram && i < strChars.Length - 1) {
      if (strChars[i] == strChars[i + 1]) isIsogram = false;
      i++;
    }
    return isIsogram;
  }
}

/*FIXME: 
public static bool IsIsogram(string str) {
    return str.ToLower().Distinct().Count()==str.Length;
}
*/
