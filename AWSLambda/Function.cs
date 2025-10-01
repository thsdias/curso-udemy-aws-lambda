using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambda;

public class Function
{

    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input">The event for the Lambda function handler to process.</param>
    /// <param name="context">The ILambdaContext that provides methods for logging and describing the Lambda environment.</param>
    /// <returns></returns>
    public string FunctionHandler(User input, ILambdaContext context)
    {
        return input.Name.ToUpper();
    }
}

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}

/*
{
"Id": "7c33edaa-bf4e-4e64-a687-1b7626f3b393",
"Name": "Hello Name"
}
*/