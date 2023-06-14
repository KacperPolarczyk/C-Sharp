using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[2];
            array[0] = 1;
            array[1] = 2;

            Console.WriteLine("Before: " + array[0] + " , " + array[1]);

            Array(ref array);

            Console.WriteLine("After: " + array[0] + " , " + array[1]);

            Console.ReadKey();
        }

        static void Array(ref int[] array)
        {
            array = new int[2];
            array[0] = -1;
            array[1] = -2;

            Console.WriteLine("Function: " + array[0] + " , " + array[1]);
        }
    }
}
