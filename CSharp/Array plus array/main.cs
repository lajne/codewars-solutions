using System;

public static class Kata {
  public static int ArrayPlusArray(int[] arr1, int[] arr2) {
    int sum = 0;
    Array.ForEach(arr1, delegate(int i) { sum += i; });
    Array.ForEach(arr2, delegate(int i) { sum += i; });

    return sum;
  }
}