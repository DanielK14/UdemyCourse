using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * This time you have to write a method that will take two arguments: 
 * a list of integers nums and an integer SumToFind. 
 * And it returns the number of possible UNIQUE pares made from this list where the sum equals to SumToFind
    Example:

    SumOfTwo([1, 1, 1, 2, 3, 4, 5, 2], 2)
     
    It should return: 1
    Explanation: there is only one pair sum of witch is equal to 2 (1,1)

ATTENTION: The main trick of this exercise is that its time complexity should be linear. 
That means you should NOT have any double/triple loops inside or deep recursion.
 */

namespace UdemyCourse.Exercises
{
    internal class Coding18_SumOfTwo
    {
        public static int SumOfTwo(int[] nums, int SumToFind)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int foundPairs = 0;

            foreach (int number in nums)
            {
                if (dic.ContainsKey(SumToFind - number) && dic[SumToFind - number] > 0)
                {
                    dic[SumToFind - number] -= 1;

                    foundPairs++;
                    continue;
                }
                if (!dic.ContainsKey(number))
                {
                    dic.Add(number, 1);
                }
            }

            return foundPairs;
        }
    }
}
