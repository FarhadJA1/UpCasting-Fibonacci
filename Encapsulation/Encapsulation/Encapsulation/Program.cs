using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();
            string result = account1.GetPassword;
            Console.WriteLine(result);
        }
    }
}
