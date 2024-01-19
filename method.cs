using System;

namespace HelloWorld
{
    class Program
    {
       /* static void method(string name="ram", int age=25)
        {
            Console.WriteLine("here " +name+" is "+age);
        }
        static void Main(string[] args)
        {
                method("jim", 18);
                method("sam", 20);
                method("jack", 22);
                method("John", 19);
                method();
        }*/
        /*static int add(int x,int y)
        {
            return(y+x);
        }
        static void Main(string[] args)
        {
            int result=add(500,679);
            Console.WriteLine(result);
        }*/
        static void func(string ch1,string ch2,string ch3)
        {
            Console.WriteLine("Child name is "+ ch2);
        }
        static void Main(string[] args)
        {
            func(ch2:"ram",ch3:"sam",ch1:"janu");
        }
    }
}