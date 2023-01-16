using System;

namespace FizzBuzz
{
  public class FizzBuzzChecker
  {
    public string Check(int num)
    {
      if (num % 3 == 0) return "Fizz";
      return $"{num}";
    }
  }
}