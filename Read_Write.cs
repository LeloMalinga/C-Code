using System;
using System.IO;

namespace Read_Write
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write on to a Notepad++ file.
            try
            {
                StreamWriter sw = new StreamWriter("C://Users/Nompumelelo/Desktop/Test.txt");

                sw.WriteLine("Example Replaced.");

                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            //Read on to a Notepad++ file.
            String line;
            try
            {
                StreamReader sr = new StreamReader("C://Users/Nompumelelo/Desktop/Test.txt");

                line = sr.ReadLine();

                while(line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
