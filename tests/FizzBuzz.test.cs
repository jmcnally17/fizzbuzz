using Xunit;
using FizzBuzz;

namespace tests
{
  public class FizzBuzzTests
  {
    [Fact]
    public void OneShouldReturnOne()
    {
      var fizzBuzzChecker = new FizzBuzzChecker();
      string result = fizzBuzzChecker.Check(1);

      Assert.Equal(result, "1");
    }
  }
}
