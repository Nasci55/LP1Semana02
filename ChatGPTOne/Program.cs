using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string userInput, response;


            while (true)
            {
                System.Console.WriteLine("Ask me anything: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {

                    case "How old are you":
                        response = "I'm 100 years old!";
                        System.Console.WriteLine(response);
                        return;
                    case "Who's your father?":
                        response = "Alan Turing?";
                        System.Console.WriteLine(response);
                        return;
                    case "Am I Alive?":
                        response = "Right now yes but not for long.";
                        System.Console.WriteLine(response);
                        return;
                    case "How can I become rich?":
                        response = "Work hard";
                        System.Console.WriteLine(response);
                        return;


                }
                if (userInput == "Exit")
                {
                    break;
                }





            }


        }
    }
}
