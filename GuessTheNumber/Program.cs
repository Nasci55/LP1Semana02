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


                System.Console.WriteLine("Input a number from 0 to 30");
                string numbInput = Console.ReadLine();

                int numb = Convert.ToInt16(numbInput);

                if (numb > numberToGuess)
                {

                }


            }

        }
    }
}
