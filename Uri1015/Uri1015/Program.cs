using System;
using System.Globalization;

namespace Uri1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valorA = Console.ReadLine().Split(' ');
            string[] valorB = Console.ReadLine().Split(' ');

            double X1, X2, Y1, Y2, distancia;
            X1 = double.Parse(valorA[0], CultureInfo.InvariantCulture);
            Y1 = double.Parse(valorA[1], CultureInfo.InvariantCulture);
            X2 = double.Parse(valorB[0], CultureInfo.InvariantCulture);
            Y2 = double.Parse(valorB[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt((Math.Pow((X2 - X1), 2) + (Math.Pow((Y2 - Y1), 2))));

            Console.WriteLine($"{distancia:F4}");
        }
    }
}
