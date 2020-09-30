using System;

public class Kata {
    public static int ExpressionsMatter(int a, int b, int c) {
        return Math.Max(Math.Max(a+b+c, (a+b)*c), Math.Max(a*(b+c), a*b*c));
    }
}