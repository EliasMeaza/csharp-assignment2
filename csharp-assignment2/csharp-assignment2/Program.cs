using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace information
{
    class program
    {
        static void Main(string[] args)
        {
            string name;
            do
            {
                Console.Write("enter your name please :");
                name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("you did not enter any thing!!");
                }
            }while(name == "");
            int age;
            do
            {
                Console.Write("enter your age please :");
                 age = Console.Read();
                if (age == null || age <0)
                {
                    Console.WriteLine("name should be greater than 0!!");
                }
            } while (age < 0 || age == null);
            Console.ReadLine();
            string course;
            do
            {
                Console.Write("enter the course your curently learning please :");
                course = Console.ReadLine();
                if (course== "")
                {
                    Console.WriteLine("you did not enter any thing!!");
                }
            } while (course == "");
            Console.WriteLine("This is your information");
            Console.WriteLine("Name :-"+name);
            Console.WriteLine("age " + age); 
            Console.WriteLine("course:-" + course);
            Console.ReadLine();


        }
    }
}

