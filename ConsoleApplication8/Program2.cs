using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8__Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //From 1 to 10
            int number = rnd.Next(1, 11);
            int my_number;
            int attempts = 0;

            Console.WriteLine("Guess the number for 1 to 10.");

            do
            {

                Console.Write("Enter your number: ");
                my_number = int.Parse(Console.ReadLine());

                if (my_number > 10 || my_number < 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Your number is incorrect. Please enter a number from 1 to 10. \n");
                    Console.ResetColor();
                }
                else
                {
                    attempts++;
                    if (my_number > number)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You entered too big number!");
                        Console.ResetColor();
                    }
                    else if (my_number < number)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You entered too small number!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("##################\n");
                        Console.WriteLine("You guessed the correct number!!! It was " + number + ".");
                        Console.Write("You tried {0} times, to guess the number.", attempts);
                        Console.Write("\n##################");
                        Console.ResetColor();
                    }
                }
            }
            while (number != my_number);

            Console.ReadKey();
        }
    }
}
