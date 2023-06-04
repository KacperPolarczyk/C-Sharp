using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WHILE | FOR | DO WHILE


            //WHILE
            int a = 1;

            while (a <= 5)
            {
                Console.WriteLine("Text " + a);
                a++;
            }

            Console.WriteLine();

            //FOR
            int b = 1;

            for ( ; b <= 5 ; b++)
            {
                Console.WriteLine("Text " + b);
            }

            Console.WriteLine();

            //DO WHILE

            do
            {
                Console.WriteLine("Text");
            }
            while (false);

            Console.ReadKey();
        }
    }
}
