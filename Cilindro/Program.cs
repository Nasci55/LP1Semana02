using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Insira a altura do cilindro");
            string cilinderHeight = Console.ReadLine();

            System.Console.WriteLine("Insira o raio do cilindro");
            string cilinderRadius = Console.ReadLine();


            (double height, double radius) = (Convert.ToDouble(cilinderHeight), Convert.ToDouble(cilinderRadius));

            double volume = (Math.PI * Math.Pow(radius, 2) * height);

            double surface = (2 * Math.PI * radius * (radius + height));

            System.Console.WriteLine($"{volume:f3}");
            System.Console.WriteLine($"{surface:f3}");




        }
    }
}
