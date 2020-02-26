using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase_Int
{
    class Program
    {
        /*
         * Swith Case int
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Num: ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 10:
                    Console.WriteLine("Num = 10");
                    break;
                case 20:
                    Console.WriteLine("Num = 20");
                    break;
                default:
                    Console.WriteLine("Neither");
                    break;
            }
            Console.ReadLine();
        }
    }
}
