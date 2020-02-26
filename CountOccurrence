using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOccurance
{
    class Program
    {
        /*
         * How to count the occurrence of each character in a string?
         */
        static void Main(string[] args)
        {
            string str = "Nompumelelo";
           
            while(str.Length > 0)
            {
                Console.Write(str[0] + " : ");

                int cnt = 0;

                for(int l = 0; l < str.Length; l++)
                {
                    if(str[0] == str[l])
                    {
                        cnt++;
                    }
                }
                Console.WriteLine(cnt);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
    }
}
