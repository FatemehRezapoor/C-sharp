// Track 10 students and their grades
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenttracker_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // You can hard core the whole 10 students which takes a long time. So the best way is to use array
            var studentgrade = new int[10];
            // How to assign values to array
            studentgrade[0] = 80; 
            studentgrade[1] = 90;
            // Is there any faster options?
            var studentgradeshort = new int[3] {80, 90, 10};
            // You don't always need to determine the size of the array. Another option is to leave the number of elements empty so you can add new inputs to the array.
            // var student = new int[] {80, 90, 10};

            Console.WriteLine(studentgrade[1]);
            Console.WriteLine(studentgradeshort[0]);

            Console.WriteLine("Read all elements in the array (for loop)");
            for (int i=0; i<studentgrade.Length;i++)
            {
                Console.WriteLine(studentgrade[i]);

            }
            // Another way to loop over an array
            Console.WriteLine("Read all elements (for each)");
            foreach (var Grade in studentgradeshort)
            {
                Console.WriteLine(Grade);
            }
            Console.ReadLine();

        }
    }
}
