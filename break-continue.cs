using System;

namespace HelloWorld
{
    class Interpolation
    {
    public static void Main(string[] args)
     {
         for(int i=0;i<=10;i++)
         {
             if(i==6)
             {
                 break;
             }
             Console.WriteLine(i);
         }
       for(int i=0;i<=20;i+=2)
         {
             if(i==6)
             {
                 continue;
             }
             Console.WriteLine(i);
         }

    }
  }
}