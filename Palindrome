using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        /*
         * How to find if the given string is a palindrome or not?
         */
         
        static void Main(string[] args)
        {
            string str, rev;
            str = "Nompumelelo";
            char[] ch = str.ToCharArray();

            Array.Reverse(ch);
            rev = new string(ch);

            bool b = str.Equals(rev,StringComparison.OrdinalIgnoreCase);

            if(b == true)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
            Console.Read();
        }
    }
}
