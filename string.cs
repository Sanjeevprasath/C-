using System;

namespace HelloWorld
{
   class Program
   {
        static void Main(string[] args)
        {
            string text="Welcome";
            string txt=" CODING";
            Console.WriteLine("The length of the string is:"+text.Length);
             Console.WriteLine(text.ToUpper());
              Console.WriteLine(txt.ToLower());
              string str=string.Concat(text,txt);
               Console.WriteLine(str);
            
        }
   }
}