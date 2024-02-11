using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Today,  imagine that you are a game developer.

And you need:

      Create An interface called IShootable. It will contain a method Shoot;

      Create a class Weapon with a Name attribute and method Label that will display the name of a weapon in the format "This is X!", where X is a name of a weapon;

      Create a class Gun that inherits from Weapon, can shoot with a "Bang!" message, has the name "Gun", and is able to show the label. 
*/

namespace UdemyCourse.Exercises
{
    internal class Coding12_InheritanceAndInterface
    {
        // place for your classes and an interface
        interface IShootable
        {
            void Shoot();
        }

        class Weapon
        {
            public string Name;

            public Weapon()
            {
                Name = "X";
            }

            public void Label()
            {
                Console.WriteLine("This is {0}!", Name);
            }
        }

        class Gun : Weapon, IShootable
        {
            public Gun()
            {
                Name = "Gun";
            }
            public void Shoot()
            {
                Console.WriteLine("Bang!");
            }
        }

        public static class Program
        {
            static public void Main(string[] args)
            {
                // new instance 
                Gun pist = new Gun();

                // test for methods
                pist.Label();
                pist.Shoot();

                // verifying the interface and the parent class
                if (pist is IShootable && pist is Weapon)
                    System.Console.WriteLine("Yes, it is my parents.");
            }
        }
    }
}
