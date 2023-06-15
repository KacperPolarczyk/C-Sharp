using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Human new_person = new Human();
            Console.WriteLine(new_person.name);

            Human new_person2 = new Human();
            new_person2.name = "John";
            Console.WriteLine(new_person2.name);

            new_person.Text();

            new_person2.Text();

            Console.ReadKey();
        }
    }
}
