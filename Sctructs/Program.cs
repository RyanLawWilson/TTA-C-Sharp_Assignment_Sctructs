using System;

namespace Sctructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, there...");
            System.Threading.Thread.Sleep(1500);

            Console.WriteLine("I'm going to create my Struct");
            Number num = new Number();
            Random rand = new Random();
            num.Amount = (decimal)rand.NextDouble() * 100000;

            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Here it is: " + num.Amount);

            Console.Read();
        }
    }
}
