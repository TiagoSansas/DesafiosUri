using System;
using System.Globalization;

namespace Uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, distancia;
            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            distancia = X / Y;

            Console.WriteLine($"{distancia:F3} km/l");

        }
    }
}
