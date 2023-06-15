using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human new_person = new Human("John", "Smith");

            new_person.Text();

            new_person.name = "Oscar";
            new_person.Text();


            Console.ReadKey();
        }
    }
}
