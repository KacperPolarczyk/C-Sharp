using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] array = new int[2, 3];
            array[0, 0] = 1;
            array[0, 1] = 2;
            array[0, 2] = 3;
            array[1, 0] = 11;
            array[1, 1] = 22;
            array[1, 2] = 33;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            //
            Console.WriteLine();
            //

            int[][] array_2 = new int[2][];
            array_2[0] = new int[3];
            array_2[1] = new int[2];
            array_2[0][0] = 2;
            array_2[0][1] = 22;
            array_2[0][2] = 23;
            array_2[1][0] = 1;
            array_2[1][1] = 3;

            for (int k = 0; k < array_2.Length; k++)
            {
                for (int m = 0; m < array_2[k].Length; m++)
                {
                    Console.Write(array_2[k][m] + " ");
                }
                Console.WriteLine();
            }

            //
            Console.WriteLine();
            //

            int[] array_3 = new int[4];

            array_3[0] = 2;
            array_3[1] = 1;
            array_3[2] = 33;
            array_3[3] = 44;

            Console.WriteLine(array_3.Length);
            Console.WriteLine(array_3.Max());
            Console.WriteLine(array_3.Min());
            Console.WriteLine(array_3.Sum());

            Console.WriteLine();

            for (int n = 0; n < array_3.Length; n++)
            {
                Console.WriteLine(array_3[n]);
            }

            Console.WriteLine();

            Array.Sort(array_3);
            for (int n = 0; n < array_3.Length; n++)
            {
                Console.WriteLine(array_3[n]);
            }

            Console.WriteLine();

            Array.Reverse(array_3);
            for (int n = 0; n < array_3.Length; n++)
            {
                Console.WriteLine(array_3[n]);
            }

            Console.ReadKey();
        }
    }
}
