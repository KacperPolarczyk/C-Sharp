using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human kacper = new Human();
            kacper.name = "Kacper";
            //kacper.setAge(19);

            kacper.Age = 19;
            //kacper.Age = -19;

            //Console.WriteLine($"I'm {kacper.name}, my age is {kacper.getAge()}.");
            Console.WriteLine($"I'm {kacper.name}, my age is {kacper.Age}.");

            Console.ReadKey();
        }
    }
}
