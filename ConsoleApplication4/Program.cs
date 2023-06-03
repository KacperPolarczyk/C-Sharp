using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int result;
            int result_2;

            // a += b

            // a++
            // a--

            a++;
            b--;

            result = a + b;
            result_2 = b % a;

            Console.WriteLine(result);
            Console.WriteLine(result_2);
            Console.WriteLine(a);
            Console.WriteLine(b);

            //

            var power = Math.Pow(2, 3);
            Console.WriteLine(power);

            var sqrt = Math.Sqrt(2);
            Console.WriteLine(sqrt);

            var absolute = Math.Abs(-10);
            Console.WriteLine(absolute);

            //

            bool var_1 = 1 == 1 && 1 != 1; // AND
            Console.WriteLine(var_1);

            bool var_2 = 1 == 1 || 1 != 1 || false || false; // OR
            Console.WriteLine(var_2);

            bool var_3 = true || true && false;
            Console.WriteLine(var_3);

            bool var_4 = (true || true) && false;
            Console.WriteLine(var_4);

            Console.ReadKey();
        }
    }
}
