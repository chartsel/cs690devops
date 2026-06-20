namespace FactorialLibrary.Tests;

using FactorialLibrary;

public class FactorialServiceTests
{
    [Fact]
    public void Test1()
    {
        var result = FactorialLibrary.FactorialService.Factorial(0);

        Assert.Equal(1,result);
    }
}
