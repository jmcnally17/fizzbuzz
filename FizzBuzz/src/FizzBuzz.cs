using System;

namespace FizzBuzz
{
  public class FizzBuzzChecker
  {
    public string Check(int num)
    {
      if (num == 3) return "Fizz";
      return $"{num}";
    }
  }
}