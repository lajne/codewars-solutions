// The rgb() method is incomplete. Complete the method so that passing in RGB decimal values will result in a hexadecimal representation being returned. The valid decimal values for RGB are 0 - 255. Any (r,g,b) argument values that fall out of that range should be rounded to the closest valid value.

// The following are examples of expected output values:

// Rgb(255, 255, 255) # returns FFFFFF
// Rgb(255, 255, 300) # returns FFFFFF
// Rgb(0,0,0) # returns 000000
// Rgb(148, 0, 211) # returns 9400D3

using System;

public class Kata {
  public static string Rgb(int r, int g, int b)  {
    string rH = IntToHex(r);
  	string gH = IntToHex(g);
  	string bH = IntToHex(b);
  
  	return rH + gH + bH;
  }
  
  public static string IntToHex(int dec) {
  	if(dec <= 0)
  		return "00";
    if(dec > 255)
      return "FF";
  
  	int hex = dec;
  	string hexStr = string.Empty;
  
  	while(dec > 0) {
  		hex = dec % 16;
  
  		if(hex < 10)
  			hexStr = hexStr.Insert(0, Convert.ToChar(hex + 48).ToString());
  		else
  			hexStr = hexStr.Insert(0, Convert.ToChar(hex + 55).ToString());
  
      dec /= 16;
  	}
  
    if(hexStr.Length == 1)
      return "0" + hexStr;
    else
  	  return hexStr;
  }
}