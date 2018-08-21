
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello"); // Print output on the terminal
            //Define a variable and print the variable
            var a = "My String"; 
            Console.WriteLine(a);
            // Save input from terminal as a variable
            var b = Console.ReadLine();
            // challenge: Multiple choice question which asks for name, age, month. Then out put the results
            Console.WriteLine("what is your name:");
            var name = Console.ReadLine();
            Console.WriteLine("How old are you:");
            var age = Console.ReadLine();
            Console.WriteLine("what month were you born in:");
            var month = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(month);
            Console.ReadLine();




        }
    }
}
