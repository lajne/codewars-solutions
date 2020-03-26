using System;

public class Kata {
  public static double Calculator(double a, double b, char op) {
    double result = 0;
    switch (op) {
      case '+':
        result = a + b;
        break;
      case '-':
        result = a - b;
        break;
      case '*':
        result = a * b;
        break;
      case '/':
        result = a / b;
        break;
      default:
        throw new ArgumentException();
    }
    return result;
  }
}