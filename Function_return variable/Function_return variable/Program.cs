using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_return_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            myfun();
            myfun2();
            var a = myfun2();
            Console.WriteLine(a);
            var b=funinput("te");
            Console.WriteLine(b);
        }
        // Function
        static void myfun() // Void means functiond doesn't have any output
        {
            Console.WriteLine("This is my function. It is void: so no output");
        }
        // Function with output
        static string myfun2() // Static means it returns outputs. // string means it returns the string value
        {
            Console.WriteLine("This is the next function. It has output");
            return Console.ReadLine(); 
        }
        // Function with input
        static string funinput(string name) // It only accepts the string input
        {
            if (name=="")
            {
                Console.WriteLine("You didn't type anything");
                return Console.ReadLine();

            }
            return name;
        }
    }
}
