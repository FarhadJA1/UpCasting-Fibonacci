using System;
using Upcasting_Downcasting.Models;

namespace Upcasting_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Upcasting

            Person teacher1 = new Teacher();
            teacher1.Age = 25;
            teacher1.Name = "Farhad";
            teacher1.Surname = "Azadaliyev";

            #endregion

           

        }
    }
}
