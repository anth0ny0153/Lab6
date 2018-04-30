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
            int sides = 0;
            //task create an app that simulates dice rolling
            Console.WriteLine("Do you want to roll the dice?(y/n)");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.WriteLine("How many sides should each die have?");
                sides = int.Parse(Console.ReadLine());
                GenerateRandomNum(sides);


                
            }
        }
        public static int GenerateRandomNum(int diceSides)
        {
            Random rnd = new Random();
            int randomNum = rnd.Next(1, diceSides);
            int randomNum2 = rnd.Next(1, diceSides);
            Console.WriteLine(randomNum);
            Console.WriteLine(randomNum2);

            return randomNum;
        }
    }
}
