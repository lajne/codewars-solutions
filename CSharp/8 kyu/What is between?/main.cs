public class Kata {
  public static int[] Between(int a, int b) {
    int len = b - a;
    int[] ints = new int[len + 1];
    for (int i = 0; i <= len; i++) {
      ints[i] = i + a;
    }
    return ints;
  }
}