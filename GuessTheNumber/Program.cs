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

            int tries = 0;


            while (true)
            {


                System.Console.Write("Insert number: ");
                string numbInput = Console.ReadLine();
                tries++;

                int numb = Convert.ToInt16(numbInput);

                if ((numb < 0) || (numb > 30))
                {
                    System.Console.WriteLine("Numbers must be between 0 and 30. Try again.");
                }


                else if (numb > numberToGuess)
                {
                    System.Console.WriteLine($"The hidden number is lower than {numb}. Try again.");
                }
                else if (numb < numberToGuess)
                {

                    System.Console.WriteLine($"The hidden number is higher than {numb}. Try again.");
                }

                else
                {
                    System.Console.WriteLine($"You found the hidden number {numberToGuess} after {tries} tries.");
                    break;
                }

            }

        }
    }
}
