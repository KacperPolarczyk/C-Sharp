using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            number = int.Parse(Console.ReadLine());

            //if (number == 1)
            //{
            //    Console.WriteLine("One");
            //}
            //else if (number == 2)
            //{
            //    Console.WriteLine("Two");
            //}
            //else if(number == 3)
            //{
            //    Console.WriteLine("Three");
            //}
            //else
            //{
            //    Console.WriteLine("Another number");

            //}

            //

            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                default:
                    Console.WriteLine("Another number");
                    break;
            }

            //

            char text = 'a';

            switch (text)
            {
                case 'a':
                    Console.WriteLine("True");
                    break;
                default: 
                    Console.WriteLine("False");
                    break;
            }

            Console.ReadKey();
        }
    }
}
