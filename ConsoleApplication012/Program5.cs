using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[2];
            array[0] = 3;
            array[1] = 4;

            Console.WriteLine("Before: " + array[0] + " , " + array[1]);
            Console.WriteLine();

            Test(array);

            Console.WriteLine("After: " + array[0] + " , " + array[1]);
            Console.ReadKey();
        }

        static void Test(int[] a)
        {
            a[0] = 333;
            a[1] = 444;

            Console.WriteLine("Function: " + a[0] + " , " + a[1]);
        }
    }
}
