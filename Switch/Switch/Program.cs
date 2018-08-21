// Organize job candidates based on their experience
// From no experienced to senior based on years of experience
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years of experience do you have?");
            var years = int.Parse(Console.ReadLine());
            // one option is using multiple conditionals
            if (years == 0)
                Console.WriteLine("No experience");
            else if (years == 1)
                Console.WriteLine("Junoir");
            else
                Console.WriteLine("Senior");
            // switch statement
            switch (years)
            {
                case 0:
                    Console.WriteLine("No experience");
                    break;
                case 1:
                    Console.WriteLine("Junoir");
                    break;
                default: // it is like the else command in if statement
                    Console.WriteLine("Senior");
                    break;
                    
                
            }
            Console.ReadLine();


        }
    }
}
