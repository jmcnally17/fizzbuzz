using System;

namespace FizzBuzz
{
  class Program
  {
    static void Main()
    {
      var fizzBuzzChecker = new FizzBuzzChecker();
      Console.WriteLine("Welcome to this FizzBuzz program!");
      Console.WriteLine("Please enter a number to be checked:");
      int number = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(fizzBuzzChecker.Check(number));
    }
  }
}
