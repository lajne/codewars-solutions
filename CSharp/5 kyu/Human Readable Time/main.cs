// Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)

// HH = hours, padded to 2 digits, range: 00 - 99
// MM = minutes, padded to 2 digits, range: 00 - 59
// SS = seconds, padded to 2 digits, range: 00 - 59
// The maximum time never exceeds 359999 (99:59:59)

// You can find some examples in the test fixtures.

public static class TimeFormat {
    public static string GetReadableTime(int seconds) {
      if ( seconds < 0 || seconds > 360000 ) {
        return null;
      } else if (seconds == 0)
        return "00:00:00";
      int sec = seconds % 60;
      int min = ((seconds - sec)/60) % 60;
      int hhh = (seconds - sec - 60 * min) / 3600;
      return string.Format("{2:00}:{1:00}:{0:00}", sec, min, hhh);
    }
}