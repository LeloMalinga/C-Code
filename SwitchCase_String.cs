using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase_String
{
    class Program
    {
        /*
         * Swith Case String
         */

        static void Main(string[] args)
        {
            Console.WriteLine("String: ");
            string str = Convert.ToString(Console.ReadLine());

            switch (str)
            {
                case "C#":
                    Console.WriteLine("This is C#");
                    break;
                case "Java":
                    Console.WriteLine("This is Java");
                    break;
                default:
                    Console.WriteLine("None");
                    break;
            }
            Console.ReadLine();
        }
    }
}
