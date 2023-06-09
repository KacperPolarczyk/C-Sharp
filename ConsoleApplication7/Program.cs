using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = int.MaxValue;
            short s = short.MaxValue;

            i = s;
            Console.WriteLine(i);

            s = (short)i;
            Console.WriteLine(s);

            //

            string s = Console.ReadLine();
            Console.WriteLine("Text: " + s);

            //

            if (Console.ReadKey().Key == ConsoleKey.D1)
            {
                Console.WriteLine("\nTrue");
            }
            else
            {
                Console.WriteLine("\nFalse");
            }

            //

            string s = Console.ReadLine();

            int i = int.Parse(s) + 2;
            Console.WriteLine(i);

            s = i.ToString();
            Console.WriteLine(s);

            //

            string s_1 = "Hello ";
            string s_2 = "World";
            string s_3 = s_1 + s_2;

            Console.WriteLine(s_3 + "!");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("{0}{1}",s_1, s_2 + "!");

            Console.ResetColor();
            Console.Write("Text");

            Console.ReadKey();
            Console.Clear();    

            //

            Console.ReadKey();
        }
    }
}
