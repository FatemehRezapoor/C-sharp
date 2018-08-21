// August 21, 2018
// When you need a structure to keep data types with different properties like int, string, ...
// OOP will give us the oppertunity to create object which has all those properties.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// In C# all of our code is created and saved inside the class. 
// The class in here is called program and when you check the project folder you find program.cs which stands for the class 
namespace Object_oriented_programming
{
    class Program // Class: Definition of all the properties you want to include inside your object.
    {
        static void Main(string[] args)
        {
            // Option1: 1- Create Multiple list 2- Ask from the user to enter the values. 3- Use add command to add those values to the end of the list

            var studentnamel = new List<string>(); //Doesn't need number of inputs
            var studentgradel = new List<int>();
            var adding = "Y";
            while (adding == "Y")
            {
                Console.WriteLine("Student name:");
                studentnamel.Add(Console.ReadLine());
                Console.WriteLine("Student grade:");
                studentgradel.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Do you want to continue(Y/N)");
                adding = Console.ReadLine();


            }


            // How to print the data
            for (int i = 0; i < studentgradel.Count; i++)
            {
                Console.WriteLine("Student name:{0} | Student grade {1}", studentnamel[i], studentgradel[i]);
            }

            // Method 2: Class and OOP

            //************************************************************

            // Method2 1- Define an object called student with attributes, 2- Add the object to the list, 3- Ask from user for the input and save them in the list

            // P.S: Tutorial: How to read class
            /* var student = new Student();
             student.Name = "sara";
             student.Grade = 20;
             student.Birthday = "May";
             student.Address = "London";
             Console.WriteLine(student.Name);
             Console.ReadLine();*/

            // Step 1: Create variable called newstudent which is an object of student
            var studentc = new Student(); // Variable is an object
            // Step 2: Let's create a list with the class.
            var studentlist = new List<Student>(); // It is adding each student as an object to the list. So the list has only object variables.

            // Ask for the input from the user for attributes
            var adding2 = "Y";
            while (adding2 == "Y")
            {
                Console.WriteLine("Student name:");
                studentc.Name=(Console.ReadLine());
                Console.WriteLine("Student grade:");
                studentc.Grade=(int.Parse(Console.ReadLine()));
                Console.WriteLine("Do you want to continue(Y/N)");
                studentlist.Add(studentc); // added the student as an object to the list
                adding2 = Console.ReadLine();


            }

            // Now let's read the studetn list
            foreach (var st in studentlist)
            {
                Console.WriteLine("Name:{0} and Grade: {1}", st.Name, st.Grade);
            }
            Console.ReadLine();
        }
    }
    // Let's create a new class

    class Student // Creating a class called student
                  // Now we need to define the attributes for the class ( properties )
    {
        public string Name; // public means the attribute can be used by other classes (string is the type of variable )
        public int Grade;
        private string Birthday; // You can make your variable private so it is not accessible by other classes
        // You can even have a function inside your class
        private int phone;
        public void setphone(int number)
        {
            phone = number;
        }

    }
}



