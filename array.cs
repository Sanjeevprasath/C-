using System;

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] arr;
            arr=new string[]{"Pulsar","Yamaha","Honda","KTM"};
            Array.Sort(arr);
            foreach(string i in arr)
            {
                Console.WriteLine(i);
            }
            int[] num={50,60,70,80,90,99,199};
            Array.Sort(num);
            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}