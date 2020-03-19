using System.Collections.Generic;

public class Kata {

  public static int[] PreFizz(int n)  {
    if (n == 1) {
      return new int[] {1};
    }
    List<int> nums = new List<int>();
    for (int i = 0; i < n; i++) {
      nums.Add(i + 1);
    }
    return nums.ToArray();
  }
  
}