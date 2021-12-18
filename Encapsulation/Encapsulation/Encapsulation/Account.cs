using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Account
    {
        private  string password = "aaaa1111";

        public string GetPassword 
        { get 
            {
                return password;
            }
            set 
            {
                password = value;
            } 
        }


    }
}
