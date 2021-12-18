using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
            int result = fibonacci.NumList(9);
            Console.WriteLine(result);
        }
    }
}
