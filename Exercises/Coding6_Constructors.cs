using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*The main of this exercise is to create 3 constructors for the class Phone:

    default constructor that sets all values to "unknown";

    constructor that takes 2 arguments (company and model) and sets them respectively. The ReleaseDay should be set to "unknown";

    constructor with 3 arguments (company, model, and release day);


Warning: You should not touch the given parts of the code! Create only 3 constructors.  
 */

namespace UdemyCourse.Exercises
{
    internal class Coding6_Constructors
    {
        public class Phone
        {
            public string Company;
            public string Model;
            public string ReleaseDay;

            // Place for your constructors
            public Phone()
            {
                Company = "unknown";
                Model = "unknown";
                ReleaseDay = "unknown";
            }

            public Phone(string CompanyName, string ModelName)
            {
                Company = CompanyName;
                Model = ModelName;
                ReleaseDay = "unknown";
            }

            public Phone(string CompanyName, string ModelName, string ReleaseDayDate)
            {
                Company = CompanyName;
                Model = ModelName;
                ReleaseDay = ReleaseDayDate;
            }

            public void Introduce()
            {
                Console.WriteLine("It is {0} created by {1}. It was released {2}.", Model, Company, ReleaseDay);
            }

        }
    }
}
