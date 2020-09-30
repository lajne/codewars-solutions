using System;

public class Kata {
  public static bool ArrayMadness(int[] a, int[] b) {
    int resA = 0, resB = 0;
    foreach (int x in a) {
      resA += (int)Math.Pow(x, 2);
    }
    foreach (int y in b) {
      resB += (int)Math.Pow(y, 3);
    }
    return resA > resB;
  }
}
