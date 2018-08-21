// Get a student name and grade from console input
// Able to handle any number of students
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_manager_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of students:");
            var number = int.Parse(Console.ReadLine());
            var studentname = new string [number];
            var studentgrade = new int[number];
            for (int i=0; i<number;i++)
            {
                Console.WriteLine("Student name:");
                studentname[i] = Console.ReadLine();
                Console.WriteLine("Student grade:");
                studentgrade[i] = int.Parse(Console.ReadLine());
            }

            // How to print the data (Method 1)
            foreach (var student in studentname)
            {
                Console.WriteLine(student);
            }
            foreach (var grade in studentgrade)
            {
                Console.WriteLine(grade);
            }

            // How to print the data (Method 2)
            for (int i=0; i < number; i++)
            {
                Console.WriteLine("Student name:{0} | Student grade {1}",studentname[i],studentgrade[i]);
            }
            Console.ReadLine();

        }
    }
}
