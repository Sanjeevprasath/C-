using System;

namespace HelloWorld
{
   class Program
   {
        static void Main(string[] args)
        {
            int s=25;
            int e=s+55;
            int m=e+s;
            m+=95;
            Console.WriteLine(m);
                Console.WriteLine(  m<s);
               Console.WriteLine(m<500 && s<20);
               Console.WriteLine(m<500 || s>30);
               Console.WriteLine(!(m<500 || s>30));
        }
   }
}