using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            while (true)
            {
                if (a > 10) {
                    break;
                }
                Console.WriteLine(a);
                a++;
            }

            //
            Console.WriteLine("");
            //

            int b = 0;

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //
            Console.WriteLine("");
            //

        one:
            Console.WriteLine("One");
            goto three;

        two:
            Console.WriteLine("Two");

        three:
            Console.WriteLine("Three");

            //
            Console.ReadKey();
        }
    }
}
