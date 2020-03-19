public class Kata {
  
  public static bool LogicalCalc(bool[] array, string op) {
    if (array.Length == 1) return array[0];

    bool result = array[0];

    for (int i = 1; i < array.Length; i++) {
        if (op == "AND") result = result && array[i];
        if (op == "OR") result = result || array[i];
        if (op == "XOR") result = result ^ array[i];
    }

    return result;
  }

}