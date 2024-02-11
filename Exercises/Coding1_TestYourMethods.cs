using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write two new methods:

    LowUpper method will take a string as input, create lower- and uppercase copies, and return the result of their join.

    Example:

    "lol" string will produse "lolLOL".


    The Count method also will take a string, but it will not return. It only will print "The amount of characters is X." with X replaced with the actual amount of characters in the string on another line.

    Example:

    "lol" string will print "The amount of characters is 3.".

Alert!

Both of them should be static and public. So add "static" and "public" keywords like those written below for the Run method.


The result of execution for the default string should be:


hey there !HEY THERE !

The amount of characters is 22. */

namespace UdemyCourse.Exercises
{
    internal class Coding1_TestYourMethods
    {
        public class Method
        {
            // Place for your methods
            public static string LowUpper(string input)
            {
                string firstPart = input.ToLower();
                string secondPart = input.ToUpper();
                return firstPart + secondPart;
            }

            public static void Count(string input)
            {
                int amount = input.Length;
                Console.WriteLine("The amount of characters is {0}.", amount);
            }

            public static void Run()
            {
                // We encourage you to test your code with different strings,
                // but don't forget to put the default string back at the end of your testing.
                string s = "HeY ThErE !";

                /// Change nothing down here 
                s = LowUpper(s);
                Console.WriteLine(s);
                Count(s);

            }
        }
    }

}
