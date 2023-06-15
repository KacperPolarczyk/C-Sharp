using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Human
    {
        //Constructor

        public Human()
        {

        }

        public Human(string nameConstructor, string surnameConstructor)
        {
            //Console.WriteLine("Constructor");
            name = nameConstructor;
            surname = surnameConstructor;
        }


        public string name = "No name";
        public string surname = "No name";

        public void Text()
        {
            Console.WriteLine(name + " " + surname);
        }

        //Destructor
        ~Human()
        {
            System.Diagnostics.Trace.WriteLine("Destructor");
            Console.WriteLine("Destructor");
        }

    }
}

