using System;
using System.Collections.Generic;


namespace Coding.Exercise
{
    public class Exercise
    {
        public static int NotHungryCats(string kitchen)
        {
            if (string.IsNullOrEmpty(kitchen) || !kitchen.Contains("F"))
            {
                throw new ArgumentException("Invalid kitchen string. It should contain at least one 'F'.");
            }

            string[] subStrings = kitchen.Split('F');
            string kitchenLeftSide = subStrings[0].Replace(" ", "");
            string kitchenRightSide = subStrings[1].Replace(" ", "");

            if (kitchenLeftSide.Length % 2 != 0 || kitchenRightSide.Length % 2 != 0)
            {
                throw new ArgumentException("Invalid kitchen string. Each side should have an even number of characters.");
            }

            List<string> listCatsLeftSide = SplitIntoPairs(kitchenLeftSide);
            List<string> listCatsRightSide = SplitIntoPairs(kitchenRightSide);

            int notHungryCats = CountOccurrences(listCatsLeftSide, "O~") + CountOccurrences(listCatsRightSide, "~O");

            return notHungryCats;
        }
        private static List<string> SplitIntoPairs(string input)
        {
            List<string> pairs = new List<string>();

            for (int i = 0; i < input.Length; i += 2)
            {
                pairs.Add(input.Substring(i, 2));
            }

            return pairs;
        }

        private static int CountOccurrences(List<string> list, string target)
        {
            int count = 0;

            foreach (var item in list)
            {
                if (item.Equals(target))
                {
                    count++;
                }
            }

            return count;
        }

    }
}
