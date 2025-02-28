using System;
using System.Runtime.ConstrainedExecution;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberToGuess = rnd.Next(31);




            while (true)
            {


                System.Console.WriteLine("Inser number:");
                string numbInput = Console.ReadLine();


                int numb = Convert.ToInt16(numbInput);

                if (numb < 0 || numb > 30)
                {
                    System.Console.WriteLine("Numbers must be between 0 and 30. Try again.");
                }


                if (numb > numberToGuess)
                {
                    System.Console.WriteLine($"The hidden number is lower than{numb}. Try again");
                }
                else if (numb < numberToGuess)
                {

                    System.Console.WriteLine($"The hidden number is higher than{numb}. Try again");
                }
                else
                {
                    System.Console.WriteLine($"You found the hidden number {numberToGuess} after ");
                }

            }

        }
    }
}
