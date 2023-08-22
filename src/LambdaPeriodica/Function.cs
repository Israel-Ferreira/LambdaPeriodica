using Amazon.Lambda.Core;
using LambdaPeriodica.Models;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaPeriodica;

public class Function
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public ResponseContent FunctionHandler(string input, ILambdaContext context)
    {
        return new ResponseContent()
        {
            Msg = "Hello World",
            StatusCode = 200
        };
    }
    
    
}
