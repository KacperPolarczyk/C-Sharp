using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 5;

            Console.WriteLine(Math(a, b));
            Console.WriteLine(Math_if(a, b));

            Console.ReadKey();
        }

        static int Math(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static string Math_if(int a, int b)
        {
            int result = a + b;
            if (result > 10)
            {
                return "Your number is greater than 10.";
            }
            else
            {
                return "Your number is less than 10.";
            }
        }
    }
}
