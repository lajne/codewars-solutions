using System;

class AreTheySame {

  public static bool comp(int[] a, int[] b) {
    try {
      if (a.Length == 0 && b.Length == 0) return true;
      if (a.Length == 0 || b.Length == 0) return false;
    
      Array.Sort(a);
      Array.Sort(b);
      
      for (int i = 0; i < a.Length; i++) {
        if (a[i]*a[i] != b[i]) {
            return false;
        }
      }
      return true;
    } catch {
      return false;
    }
  }
}