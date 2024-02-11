using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Right now, you are going to put your hand on Math Class.

Subject:

Complete the Run Method with code that will:

    Pars line into int if it is possible. Otherwise, or if the value is not in the range not below of 0 and not larger than 180, or between 0 and 180 both inclusive, display "Check the input!" on the new line and return;

    if the parsing was successful, calculate and print:
        Cosine of this angle in the format "Cos = X", where X is the value;
        Sine of the angle in the format "Sin = X", where X is the value;
        Tangent of the angle in the format "Tg = X", where X is the value;

Hint: All of those methods expect us to provide radians as input. In order to convert the angle to radians, use the method ConvertToRadians. 
 */

namespace UdemyCourse.Exercises
{
    internal class Coding14_MathClass
    {
        public class Exercise
        {
            public static double ConvertToRadians(double angle)
            {
                return (Math.PI / 180) * angle;
            }
            public static void Run(string line)
            {
                int number;
                if (int.TryParse(line, out number))
                {
                    if (0 <= number && number <= 180)
                    {
                        double rad = ConvertToRadians(number);
                        Console.WriteLine("Cos = {0}", Math.Cos(rad));
                        Console.WriteLine("Sin = {0}", Math.Sin(rad));
                        Console.WriteLine("Tg = {0}", Math.Tan(rad));
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Check the input!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Check the input!");
                    return;// TODO
                }
            }
        }
    }
}
