using FizzBuzz;

namespace tests
{
  public class FizzBuzzTests
  {
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void NumberReturnsNumber(int value)
    {
      var fizzBuzzChecker = new FizzBuzzChecker();
      string result = fizzBuzzChecker.Check(value);

      Assert.Equal(result, $"{value}");
    }

    [Theory]
    [InlineData(3)]
    [InlineData(9)]
    public void NumberReturnsFizz(int value)
    {
      var fizzBuzzChecker = new FizzBuzzChecker();
      string result = fizzBuzzChecker.Check(value);

      Assert.Equal(result, "Fizz");
    }

    [Theory]
    [InlineData(5)]
    [InlineData(20)]
    public void NumberReturnsBuzz(int value)
    {
      var fizzBuzzChecker = new FizzBuzzChecker();
      string result = fizzBuzzChecker.Check(value);

      Assert.Equal(result, "Buzz");
    }
  }
}
