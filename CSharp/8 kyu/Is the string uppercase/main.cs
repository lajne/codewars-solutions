public static class StringExtensions {

  public static bool IsUpperCase(this string text) {
    int upperCount = 0;
    int whitespaceCount = 0;
    for (int i = 0; i < text.Length; i++) {
      if (!char.IsWhiteSpace(text[i])) {
        if (char.IsUpper(text[i])) {
          upperCount++;
        }
      } else {
        whitespaceCount++;
      }
    }
    return upperCount == (text.Length - whitespaceCount) ? true : false;
  }  
  
}