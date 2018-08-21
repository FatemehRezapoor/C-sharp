// For loop and how it can be used
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 1;
            while (counter<=3)
            {
                Console.WriteLine(counter);
                counter++;
            }
            for (int i=0; i<4; i++)
            {
                Console.WriteLine(i);
            }
            // Challenge: Count from 1-5, then back to 1, Repeat 2 times
            Console.WriteLine("This is from the challenge: Count Up");
            var a = 1;
            while (a <= 2)
            {
                for (int count = 1; count <= 5; count++)
                {
                    Console.WriteLine(count);
                }
                Console.WriteLine("This is from the challenge: Count Down");
                for (int count = 5; count >= 1; count--)
                {
                    Console.WriteLine(count);
                }
                a++;
            }
            Console.ReadLine();

        }
    }
}
