using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int c = 3;

            //Console.WriteLine("Before: " + a);
            Test(out a);
            Console.WriteLine("After: " + a);

            Test_2(ref c);
            Console.WriteLine();
            Console.WriteLine("C: " + c);

            Console.ReadKey();
        }

        static void Test(out int b)
        {
            b = 5;
            b += 5;
            Console.WriteLine("Test function: " + b);
        }
        static void Test_2(ref int c)
        {
            c += 2;
            Console.WriteLine("Test function: " + c);
        }
    }
}
