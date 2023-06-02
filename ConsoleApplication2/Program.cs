using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            //integers
            int variable_1 = int.MinValue + 100;
            Console.WriteLine(variable_1);

            uint variable_uint = uint.MaxValue;
            Console.WriteLine(variable_uint);
            
            var variable_2 = "Hello";
            Console.WriteLine(variable_2);
            
            //

            byte variable_3 = Byte.MaxValue;
            Console.WriteLine(variable_3);

            sbyte variable_sbyte = sbyte.MinValue;
            Console.WriteLine(variable_sbyte);
            
            //

            short variable_4 = short.MaxValue;
            Console.WriteLine(variable_4);

            ushort variable_5 = ushort.MaxValue;
            Console.WriteLine(variable_5);

            //
            
            long variable_long = long.MaxValue;
            Console.WriteLine(variable_long);

            ulong variable_ulong = ulong.MaxValue;
            Console.WriteLine(variable_ulong);
            
            //

            Console.ReadKey();
        }
    }
}