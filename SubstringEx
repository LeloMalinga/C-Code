using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringEx
{
    class Program
    {
        /*
         * How to find all possible substring of a given string
         */

        public static void substringexample(string str)
        {
            for(int l = 0; l < str.Length; ++l)
            {
                StringBuilder subStr = new StringBuilder(str.Length - l);

                for(int m = 1; m < str.Length; ++m)
                {
                    subStr.Append(str[m]);
                    Console.Write(subStr + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            string result = "abcd";
            substringexample(result);
            Console.WriteLine(result + " ");
            Console.Read();
        }
    }
}
