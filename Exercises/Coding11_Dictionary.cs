using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Dictionaries and hashtables are very powerful data structures that can speed up your code.

Let's get used to them!

In this exercise, you have to create a method that will declare a dictionary with int and string key-value pairs. It should contain values from 0 to 5 with its spelling in lowercase ( 1,  "one" ).

As input, this method will get an int. The integer should be tested if it exists in the structure or not. And corresponding value should be returned otherwise, "nope" should be returned.
*/

namespace UdemyCourse.Exercises
{
    internal class Coding11_Dictionary
    {
        public class Speller
        {
            public static string Convert(int i)
            {
                Dictionary<int, string> numbers = new Dictionary<int, string>();

                numbers.Add(0, "zero");
                numbers.Add(1, "one");
                numbers.Add(2, "two");
                numbers.Add(3, "three");
                numbers.Add(4, "four");
                numbers.Add(5, "five");

                string _string = "";

                if (numbers.TryGetValue(i, out _string))
                {
                    return numbers[i];
                }
                else
                {
                    return "nope";
                }
            }
        }
    }
}
