using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();

            int x = 100_000;

            stopWatch.Start();
            BuildString(x);
            //Console.WriteLine(BuildString(x));
            stopWatch.Stop();

            Console.WriteLine("Standard method: {0} ms", stopWatch.ElapsedMilliseconds);

            Console.WriteLine();
            stopWatch.Reset();

            stopWatch.Start();
            BuildStringBuilder(x);
            //Console.WriteLine(BuildStringBuilder(x));
            stopWatch.Stop();

            Console.WriteLine("StringBuilder method: {0} ms", stopWatch.ElapsedMilliseconds);

            Console.ReadKey();
        }

        /// <summary>
        /// This method builds string.
        /// </summary>
        /// <param name="xTimes">Enter the lenght of the loop</param>
        /// <returns>It returns the finished text</returns>

        public static string BuildString(int xTimes)
        {
            string text = "";
            for (int i = 0; i < xTimes; i++)
            {
                text += i;
            }
            return text;
        }

        public static string BuildStringBuilder(int xTimes)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < xTimes; i++)
            {
                stringBuilder.Append(i);
            }
            return stringBuilder.ToString();
        }
    }
}
