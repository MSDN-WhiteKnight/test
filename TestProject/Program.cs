using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world");
            Console.WriteLine("{0}+{1}={2}", 1.1, 1.2, (1.1+1.2));
            
            try{ Console.ReadKey(); }
            catch(Exception ex){ Console.WriteLine(ex.GetType().ToString()+": "+ex.Message); }
        }
    }
}
