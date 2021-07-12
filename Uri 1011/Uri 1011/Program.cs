using System;
using System.Globalization;

namespace Uri_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            int raio;
            double pi = 3.14159,volume;

            raio = int.Parse(Console.ReadLine());

            volume = (4.0 / 3) * ((pi * Math.Pow(raio, 3)));

            Console.WriteLine($"VOLUME = {volume:F3}",CultureInfo.InvariantCulture);
        }
    }
}
