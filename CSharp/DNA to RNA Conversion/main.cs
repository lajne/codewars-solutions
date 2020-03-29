using System;
using System.Text.RegularExpressions;

namespace Converter {
  public class Converter {
    public string dnaToRna(string dna) {
      return new Regex("(T)").Replace(dna, "U");
    }
  }
}