using System;
using System.Linq;

public static class Kata {
    public static int TotalPoints(string[] games) {
        int points = 0;
        foreach (var game in games) {
          points += game[0] > game[2] ? 3 : game[0] == game[2] ? 1 : 0;
        }
        return points;
    }
}