using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            Math("Result: ", a, b, d:2);
            Math("Result: ", 4, 3, d: 3);
            Math("Result: ", 23, 312, d:4);
            Console.ReadKey();
        }

        static void Math(string text, int a, int b, int c = 2, int d = 0)
        {
            int result = a + b + c + d;
            Console.WriteLine(text + result);
        }
    }
}
