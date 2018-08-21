// August 20, 2018
//Challenge: Multiple choice question which asks for name, age, month. Then out put the results

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_choice
{
    class Program
    {
        static void Main(string[] args)
        {
            // challenge: Multiple choice question which asks for name, age, month. Then out put the results
            Console.WriteLine("what is your name:");
            var name = Console.ReadLine();
            Console.WriteLine("How old are you:");
            var age = Console.ReadLine();
            Console.WriteLine("what month were you born in:");
            var month = Console.ReadLine();
            Console.WriteLine(name);
            // Another way to output the variable
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine(age);
            Console.WriteLine(month);
            //Console.ReadLine();

            // Let's add a if condition to the code

            if (month == "April")
            {
                Console.WriteLine("You are born in April");
            }
            else if (month == "June")
            {
                Console.WriteLine("Your month is June");
            }
            else
            {
                Console.WriteLine("You are born in Different month");
            }
            Console.ReadLine();
        }
    }
}
