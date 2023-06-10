using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rectangle drawing generator

            Console.WriteLine("Enter X (width) and Y (height) and I will create for you a rectangular shape.");
            Console.WriteLine("###########");

            Console.WriteLine("Enter X:");
            string width = Console.ReadLine();

            Console.WriteLine("Enter Y:");
            string height = Console.ReadLine();

            int x = int.Parse(width);
            int y = int.Parse(height);

            //Console.WriteLine(x + " " + y);

            Console.WriteLine("###########");

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();   
            }

            Console.ReadKey();
        }
    }
}
