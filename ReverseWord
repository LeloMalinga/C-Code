using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWord
{
    class Program
    {
        /*
         * How to reverse each word in a given string
         */
        static void Main(string[] args)
        {
            string str = "How to reverse each word in a given string?";
            string strRev = "";

            foreach(var word in str.Split(' '))
            {
                string temp = "";

                foreach(var s in word.ToCharArray())
                {
                    temp = s + temp;
                }
                strRev = strRev + temp;
            }
            Console.WriteLine(strRev + " ");
            Console.Read();
        }
    }
}
