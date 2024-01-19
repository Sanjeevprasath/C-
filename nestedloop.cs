using System;

namespace HelloWorld
{
    class Interpolation
    {
    public static void Main(string[] args)
     {
         Console.WriteLine("Enter n:");
         int n=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=n;i++)
        {
            Console.WriteLine("outer="+i);
    
        for(int j=1;j<=n;j++)
        {
            Console.WriteLine("      inner="+j);
        }
     }
    }
  }
}