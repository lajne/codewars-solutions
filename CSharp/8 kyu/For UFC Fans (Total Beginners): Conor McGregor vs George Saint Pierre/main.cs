using System;

public static class Kata {
  public static string Quote(string fighter) {
    string mcG = "I'd like to take this chance to apologize.. To absolutely NOBODY!";
    string stP = "I am not impressed by your performance.";
    return fighter.ToLower() == "conor mcgregor" ? mcG : stP;
  }
}