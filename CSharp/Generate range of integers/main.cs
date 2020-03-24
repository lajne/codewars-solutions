using System.Collections.Generic;

public class Kata {
  public static int[] GenerateRange(int min, int max, int step) {
    var range = new List<int>();
    for (int i = min; i <= max; i += step) {
      range.Add(i);
    }
    return range.ToArray();
  }
}