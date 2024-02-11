using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Hey there, it is going to be an advanced challenge related to Lambda expressions!

Subject:

Create a dictionary that will contain <string, Func<>> pairs. The keys will be operation signs "+", "-", "/", "*" and values will be the lambda expressions that will perform the corresponding operation on two floats and return a result with type float.

One more time in detail:

    Create and store using static keyword Lambda expressions with names Plus, Minus, Divide and Multiply.
    You can store function as follow:
    static Func<int, int> Name = (a) => a;
    Create a static dictionary called Operators that uses a string as a Key and lambda function as a value.
    Example: {"sign", Function}
    Create a static method OperationGet that will get as input a string, test if this string is a Key in the dictionary and if positive return function otherwise returns null.

Remember, this is an advanced topic. Take your time and read the Lambda documentation.
*/

namespace UdemyCourse.Exercises
{
    internal class Coding16_Lambda
    {
        public class Run
        {
            static Func<int, int, int> Plus = (a, b) => a + b;
            static Func<int, int, int> Minus = (a, b) => a - b;
            static Func<int, int, int> Divide = (a, b) => a / b;
            static Func<int, int, int> Multiply = (a, b) => a * b;

            static Dictionary<string, Func<int, int, int>> Operators = new Dictionary<string, Func<int, int, int>>{
            { "plus", Plus },
            { "minus", Minus },
            { "divide", Divide },
            { "multiply", Multiply },
            { "+", Plus },
            { "-", Minus },
            { "/", Divide },
            { "*", Multiply }
        };

            public static Func<int, int, int> OperationGet(string operation)
            {
                if (Operators.ContainsKey(operation.ToLower()))
                {
                    return Operators[operation.ToLower()];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
