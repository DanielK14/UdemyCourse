﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a method that returns a list of even integer numbers between 100 and 170 (inclusive).
 */

namespace UdemyCourse.Exercises
{
    internal class Coding10_Lists
    {
        public class ListsExercise
        {

            public static List<int> Solution()
            {
                // TODO: write your solution here
                List<int> evenNumbers = new List<int>();
                for (int i = 100; i <= 170; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenNumbers.Add(i);
                    }
                }
                return evenNumbers;
            }

        }
    }
}
