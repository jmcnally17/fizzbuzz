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
    public void NumberReturnsFizz(int value)
    {
      var fizzBuzzChecker = new FizzBuzzChecker();
      string result = fizzBuzzChecker.Check(value);

      Assert.Equal(result, "Fizz");
    }
  }
}
