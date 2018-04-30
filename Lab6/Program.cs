using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                int sides = 0;
                //task create an app that simulates dice rolling
                Console.WriteLine("Do you want to roll the dice?(y/n)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    Console.WriteLine("How many sides should each die have?");
                    sides = int.Parse(Console.ReadLine());
                    GenerateRandomNum(sides);
                }
                else if (answer == "n") ;
                {
                    repeat = false;
                }
                repeat = Confirm("Do you want to run the program again? (y/n): ");
            }
            Console.WriteLine("Bye!");
        }
        public static bool Confirm(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (input.ToLower() == "y") //continue
            {
                return true;
            }

            else if (input.ToLower() == "n") // ends program
            {
                return false;
            }

            else
            {
                Console.WriteLine("Invalid Input");
                return Confirm(message);
            }
        }
        public static void GenerateRandomNum(int diceSides)
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(1, diceSides + 1);
            int randomNum2 = rnd.Next(1, diceSides + 1);
            Console.WriteLine(randomNum);
            Console.WriteLine(randomNum2);
        }
    }
}
