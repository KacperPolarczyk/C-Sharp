using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[365];
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //array[0] = 2;
            //Console.WriteLine(array[0]);

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }

            Console.ReadKey();
        }
    }
}
