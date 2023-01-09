namespace FizzBuzzNS
{
  class Program
  {
    static void Main()
    {
      FizzBuzz();
    }

    static void FizzBuzz()
    {
      Console.WriteLine("Welcome to this FizzBuzz program!");
      Console.WriteLine("Enter a number to be checked:");
      int number = Convert.ToInt32(Console.ReadLine());
      if (number % 3 == 0 && number % 5 == 0)
      {
        Console.WriteLine("FizzBuzz");
      }
      else if (number % 3 == 0)
      {
        Console.WriteLine("fizz");
      }
      else if (number % 5 == 0)
      {
        Console.WriteLine("buzz");
      }
      else
      {
        Console.WriteLine(number);
      }
    }
  }
}
