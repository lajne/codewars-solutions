using System;

public class Kata {
  
  public static int HexToDec(string hexString) {
    int n;
    
    if(hexString.Contains("-")) {
      string x = hexString.Remove(0, 1);
      n = Convert.ToInt32(x, 16);
      return -n;
    }

    n = Convert.ToInt32(hexString, 16);
    return n;
  }
  
}