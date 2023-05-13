using Amazon.Lambda.Core;
using Models;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace FavouriteColor
{
    public class Function
    {

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string FunctionHandler(Person person, ILambdaContext context)
        {
            return person.Sex switch
            {
                Sex.Male => "Blue",
                Sex.Female => "Pink",
                _ => throw new ArgumentNullException(nameof(person.Sex)),
            };
        }
    }
}