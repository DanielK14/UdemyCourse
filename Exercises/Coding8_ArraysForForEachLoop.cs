using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*This time, you have to fill out two methods:

    GetOdd will get an array as input and will print every odd number from it to the console;

    GetEven will do the same for evens;
*/

namespace UdemyCourse.Exercises
{
    internal class Coding8_ArraysForForEachLoop
    {
        public class Exercise
        {
            public static void GetOdd(int[] Array)
            {
                for (int i = 0; i < Array.Length; i += 2)
                {
                    Console.WriteLine(Array[i]);
                }
            }

            public static void GetEven(int[] Array)
            {
                for (int i = 1; i < Array.Length; i += 2)
                {
                    Console.WriteLine(Array[i]);
                }
            }

            public static void Run()
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                GetOdd(array);
                GetEven(array);

            }
        }
    }
}
