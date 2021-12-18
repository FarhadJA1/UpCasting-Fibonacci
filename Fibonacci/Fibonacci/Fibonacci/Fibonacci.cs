using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    public class Fibonacci
    {
        
        public int NumList(int n)
        {
            int a = 0;
            int b = 1;
            int c = 1;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                
            }
            return b;
        }
    }
}
