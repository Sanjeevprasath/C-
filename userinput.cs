using System;

namespace HelloWorld
{
   class Program
   {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the username:");
            string name=Console.ReadLine();
            Console.WriteLine("username is "+ name);
             Console.WriteLine("Enter the age:");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your age is "+age);
        }
   }
}