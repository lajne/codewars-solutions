using System;

public class MaxDiffLength {
    
    public static int Mxdiflg(string[] a1, string[] a2) {
        if (a1.Length == 0 || a2.Length == 0)
          return -1;
        
        int maxDiffLength = 0;

        foreach (var x in a1) {
          foreach (var y in a2) {
            maxDiffLength = Math.Max(maxDiffLength, Math.Abs(x.Length - y.Length));
          }
        }
        return maxDiffLength;
    }
}