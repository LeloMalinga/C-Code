using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class Program
    {
        /*
         * How to remove duplicate characters from a string?
        */
        
        public static void removeduplicate(string str)
        {
            string result = string.Empty;

            for(int i = 0; i < str.Length; i++)
            {
                if(!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            string str2 = "Nompumelelo";
            removeduplicate(str2);
            Console.WriteLine(str2);
            Console.Read();
        }
    }
}
