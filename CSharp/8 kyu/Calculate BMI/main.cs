using System;

public class Kata {
  public static string Bmi(double weight, double height) {
    double bmi = weight / Math.Pow(height, 2);
    string judgement;
    if (bmi <= 18.5)
      judgement = "Underweight";
    else if (bmi <= 25.0)
      judgement = "Normal";
    else if (bmi <= 30.0)
      judgement = "Overweight";
    else
      judgement = "Obese";
    return judgement;
  }
}