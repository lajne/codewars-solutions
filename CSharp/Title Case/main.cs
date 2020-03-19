using System;
using System.Linq;
using static System.Console;
using System.Collections.Generic;

public class Kata {
  
  public static string TitleCase(string title, string minorWords="") {
    
    var rest = new List<string>();
    var full = new List<string>();
    string[] sentence = title.ToLower().Split(null);
      
    if (String.IsNullOrEmpty(minorWords) && title.Length > 1) {
      for (int i = 0; i < sentence.Length; i++) {
        full.Add(char.ToUpper(sentence[i][0]) + sentence[i].Substring(1, sentence[i].Length - 1));
      }
      return String.Join(' ', full.ToArray());
    } else if (String.IsNullOrEmpty(minorWords)) {
      return "";
    }
    
    string[] minorsArr = minorWords.ToLower().Split(null);
    string first = char.ToUpper(sentence[0][0]) + sentence[0].Substring(1, sentence[0].Length - 1);
    var last = sentence.Skip(1).Take(sentence.Length - 1).ToArray();
    for (int i = 0; i < last.Length; i++) {
      if (Array.IndexOf(minorsArr, last[i]) > -1) {
        rest.Add(last[i]);
      } else {
        rest.Add(char.ToUpper(last[i][0]) + last[i].Substring(1, last[i].Length - 1));
      }
    }
    
    string strRest = String.Join(' ', rest.ToArray());
    
    if(sentence.Length == 1 && minorsArr.Length == 1)
      return first;
    else 
      return first + ' ' + strRest;
  }
}