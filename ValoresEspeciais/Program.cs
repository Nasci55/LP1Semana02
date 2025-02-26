using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine(int.MinValue);
            System.Console.WriteLine(int.MaxValue);
            System.Console.WriteLine(byte.MinValue);
            System.Console.WriteLine(byte.MaxValue);
            System.Console.WriteLine(sbyte.MinValue);
            System.Console.WriteLine(sbyte.MaxValue);
            System.Console.WriteLine(decimal.MinValue);
            System.Console.WriteLine(decimal.MaxValue);
            System.Console.WriteLine(double.MinValue);
            System.Console.WriteLine(double.MaxValue);
            System.Console.WriteLine(float.MinValue);
            System.Console.WriteLine(float.MaxValue);
            System.Console.WriteLine(char.MinValue);
            System.Console.WriteLine(char.MaxValue);
            System.Console.WriteLine(uint.MinValue);
            System.Console.WriteLine(uint.MaxValue);
            System.Console.WriteLine(long.MinValue);
            System.Console.WriteLine(ulong.MaxValue);
            System.Console.WriteLine(short.MinValue);
            System.Console.WriteLine(ushort.MaxValue);



            System.Console.WriteLine(double.PositiveInfinity);
            System.Console.WriteLine(double.NegativeInfinity);
            System.Console.WriteLine(float.PositiveInfinity);
            System.Console.WriteLine(float.NegativeInfinity);
            System.Console.WriteLine(float.NaN);
            System.Console.WriteLine(double.NaN);


            uint overflow = uint.MaxValue;
            System.Console.WriteLine((uint)(overflow + 1));

            float overFloat = float.MaxValue;
            System.Console.WriteLine(2 * overFloat);
            System.Console.WriteLine(overFloat + 1);


            float uf1, uf2; 

            uf1 = uf2 = 100000000; 

            System.Console.WriteLine(uf1 == uf2 + 0.00001f);    


        }
    }
}
