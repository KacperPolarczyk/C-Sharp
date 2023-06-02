using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Floating point numbers

            float variable_1 = 1.121F;
            double variable_2 = 1.121;
            decimal variable_3 = 1.121M;

            Console.WriteLine(variable_1);
            Console.WriteLine(variable_2);
            Console.WriteLine(variable_3);

            //Text

            string variable_text = "Text";
            Console.WriteLine(variable_text);

            char variable_char = 'A';
            Console.WriteLine(variable_char);

            bool variable_true = true;
            bool variable_false = false;

            Console.WriteLine(variable_true);
            Console.WriteLine(variable_false);

            bool variable_bool = 5 > 2;
            Console.WriteLine(variable_bool);

            bool variable_bool2 = 5 < 2;
            Console.WriteLine(variable_bool2);

            Console.ReadKey();
        }
    }
}
