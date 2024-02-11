using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Implement conditions for the given while loop.

To pass the tests, your loop should skip all divisible by 3 values and stops running when i = 10.

Warning: You cannot touch the given parts of the code! You can add your conditions only inside the loop!

Warning2: This while loop is an infinite loop! To avoid it causing you issues we implemented the current if statement that you can find. This, with the proper solution in place, should not be needed anymore. Before running the tests, find a way to stop it without reaching the pre-placed break!
 */

namespace UdemyCourse.Exercises
{
    internal class Coding5_BreakAndContinue
    {
        public class Exercise
        {
            public static void Run()
            {
                int i = -10;

                while (true)
                {

                    if (i % 3 == 0)
                    {
                        i++;
                        continue;
                    }
                    if (i == 10)
                    {
                        break;
                    }
                    if (i == 11)
                    {
                        Console.WriteLine(" FINAL BREAK REACHED! This should not happen!");
                        break;
                    }
                    Console.WriteLine(i++);
                }
            }
        }
    }
}
