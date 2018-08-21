// August 20, 2018
// Challenge: Passcode ( ask for a passcode from user, comapre with the real passcode, wirte the correct message
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) // You can only have 1 main function in your project. There are inputs to the function, from strings to argument which will be called from the terminal. 
        {
            var passcode = "secret";
            Console.WriteLine("Please inter the password:");
            var user = Console.ReadLine();
            if (user == passcode)
            {
                Console.WriteLine("Welcome to the system");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
            Writetryagain();
            Console.ReadLine();
        }
    // My function.
        static void Writetryagain()
        {
                Console.WriteLine("This is from my function");
        }
    
    }
}
