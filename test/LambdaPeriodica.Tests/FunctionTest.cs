using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

namespace LambdaPeriodica.Tests;

public class FunctionTest
{
    [Fact]
    public void TestToUpperFunction()
    {

        // Invoke the lambda function and confirm the string was upper cased.
        var function = new Function();
        var context = new TestLambdaContext();
        var result = function.FunctionHandler("hello world", context);
        
        Assert.Equal(200, result.StatusCode);
        Assert.Equal("Hello World", result.Msg);
    }
    
}
