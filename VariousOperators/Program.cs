using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Insere número inteiro-não negativo:");
            string userInput;

            userInput = Console.ReadLine();

            byte numbInputByte = Convert.ToByte(userInput);

            System.Console.WriteLine(numbInputByte/2);
            System.Console.WriteLine(numbInputByte << 3);
            System.Console.WriteLine(numbInputByte ^ 6);
            System.Console.WriteLine((numbInputByte > 10)? true:false);

        }
    }
}
