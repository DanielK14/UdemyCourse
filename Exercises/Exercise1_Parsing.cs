using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourse.Exercises
{
    internal class Exercise1_Parsing
    {
        static void Main(string[] args)

        {

            string stringForFloat = "0.85"; // datatype should be float

            float floatString = float.Parse(stringForFloat);

            string stringForInt = "12345"; // datatype should be int

            int intString = int.Parse(stringForInt);

        }
    }
}
