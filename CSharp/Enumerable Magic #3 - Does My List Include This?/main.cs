using System;

public class Kata {
  public static bool Include(int[] arr, int item) {
    return Array.Exists(arr, element => element == item);
  }
}