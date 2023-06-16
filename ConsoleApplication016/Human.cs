using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    internal class Human
    {
        public string name;

        //private int age;

        //public int age
        //{ 
        //    get; 
        //    set;
        //}

        private int age;

        public int Age
        {
            get { return age; }
            set 
            { 
                if(value >= 0 && value <= 200)
                {
                    age = value;
                }
                else
                    age = 0;
            }
        }

        //public int getAge()
        //{
        //    return age;
        //}

        //public int setAge(int human_age)
        //{
        //    if (age >= 0 && age <= 200)
        //    {
        //        return age = human_age;
        //    }
        //    else
        //        return 0;

        //}
    }
}
