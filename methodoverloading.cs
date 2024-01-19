using System;

namespace HelloWorld
{
    class Overloading
    {
        static int add(int x,int y)
        {
            return x+y;
        }
        static double add(double x,double y)
        {
            return x+y;
        }
        static void Main(string[] args)
        {
            int result=add(100,200);
            double result2=add(300.55,598.46);
            Console.WriteLine(result);
              Console.WriteLine(result2);
        }
    }
}