using System;

namespace ClassExample
{
    public class Testing
    {
        public Testing()
        {
            Name = "Lelo";
        }
        public string Name { get; }
        public override string ToString()
        {
            return Name;
        }
    }
    class Program
    {  
        static void Main(string[] args)
        {
            Testing test = new Testing();

            Console.WriteLine(test);
        }
    }
}
