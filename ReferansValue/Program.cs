using System;

namespace ReferansValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine(add(a,b));
            Console.WriteLine(a);
            Console.WriteLine(add2(ref a, b));
            Console.WriteLine(a);
            static int  add(int a, int b)
            {
                a = 20;
                return a + b;
            }

            static int add2(ref int a, int b)
            {
                a = 20;
                return a + b;
            }
        }
    }
}
