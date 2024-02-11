using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Implement method Check that will take an int as an argument and check if it is an odd number or even. 
 * Depending on the testing result, it should print a message on the new line "Odd" or "Even" respectively.
 */

namespace UdemyCourse.Exercises
{
    internal class Coding2_If_Else
    {
        public class Exercise
        {
            public static void Check(int number)
            {
                // TODO
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
        }
    }
}
