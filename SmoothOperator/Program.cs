using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string insNumb;

            System.Console.WriteLine("Insere número inteiro: ");
            insNumb = Console.ReadLine();

            sbyte numbConv = Convert.ToSByte(insNumb);


            numbConv--;
            System.Console.WriteLine(numbConv);
            numbConv++;
            System.Console.WriteLine(numbConv);




        }
    }
}
