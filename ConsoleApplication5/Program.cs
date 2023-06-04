using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9;

            if (a > 0 && a > 9)
            {
                Console.WriteLine("The number A is greater than 0 and 9.");
            }
            else if (a == 9)
            {
                Console.WriteLine("The number A is equal to 9.");
            }
            else if(a > 0) 
            {
                Console.WriteLine("The number A is greater than 0.");
            }
            else if(a == 0) 
            {
                Console.WriteLine("The number A is equal to 0.");
            }
            else
            {
                Console.WriteLine("The number A is less than 0.");
            }
            Console.ReadKey();
        }
    }
}
