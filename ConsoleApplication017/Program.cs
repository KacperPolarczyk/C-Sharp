using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object obj = 1;
            //object obj2 = "Text";

            Console.WriteLine(TextGenerator("I'm #0 and I'am #1 years old.", "Kacper", 19));

            Console.ReadKey();
        }

        public static string TextGenerator(string text, params object[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                text = text.Replace("#" + i, args[i].ToString());
            }

            return text;
        }
    }
}
