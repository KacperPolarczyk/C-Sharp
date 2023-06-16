using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static
            Console.WriteLine(HumanStatic.population);

            //Non-static

            Human new_human = new Human();
            Console.WriteLine(new_human.name);

            Human new_human2 = new Human();
            new_human2.name = "James";
            Console.WriteLine(new_human2.name);

            //

            Console.WriteLine(Human.population);

            Console.ReadKey();
        }
    }
}
