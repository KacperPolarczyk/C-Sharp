using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 5;
            double c = 6.5;

            Math(a, b, c);
            Console.ReadKey();
        }

        static void Math(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Result: " + result);
        }

        static void Math(int a, int b, double c)
        {
            double result = a + b + c;
            Console.WriteLine("Result: " + result);
        }
    }
}
