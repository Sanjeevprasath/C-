using System;

namespace Helloworld
{
    class Program
    {
        string name="C# in W3 Schools";
        int num=1363445;
    
    public static void Main(string[] args)
    {
        Program myobj=new Program();
        Program myobj2=new Program();
        Console.WriteLine(myobj.name);
        Console.WriteLine(myobj2.num);
    }
   }
}