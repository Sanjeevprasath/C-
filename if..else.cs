using System;

namespace HelloWorld
{
    class Interpolation
    {
    public static void Main(string[] args)
     {
        //int age;
        int s=18;
        Console.WriteLine("Enter the age:");
        int age=Convert.ToInt32(Console.ReadLine());
        if(age>s)
        {
            Console.WriteLine("you can vote");
        }
        else if(age==18)
        {
            Console.WriteLine("eligible age for voting");
        }
        else
        {
            Console.WriteLine("you can't vote");
        }
    }
   }
}