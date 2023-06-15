using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Human
    {
        public string name = "Steve";
        public string surname = "Smith";

        public void Text()
        {
            Console.WriteLine("Hello! I'm " + name + " " + surname);
        }
    }
}
