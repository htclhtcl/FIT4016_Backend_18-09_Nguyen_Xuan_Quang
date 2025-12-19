using System;

namespace Recursion
{
    class Program
    {
        static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("5! = " + Factorial(5));
            Console.WriteLine("10! = " + Factorial(10));
        }
    }
}
