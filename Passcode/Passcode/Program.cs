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
        static void Main(string[] args)
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
            // What if we want to add a while loop to the program and ask from user to try again
            var i = 1;
            while (i <= 4 & user != passcode)
            {
                if (i == 4)
                {
                    Console.WriteLine("Restriction: Access Denied");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("Wrong code. Please try again");
                if (i == 3)
                {
                    Console.WriteLine("This is your last try");
                }
                user = Console.ReadLine();
                i = i + 1;
            }
            Console.WriteLine("Welcome to the system");
            Console.ReadLine();

        }
    }
}
