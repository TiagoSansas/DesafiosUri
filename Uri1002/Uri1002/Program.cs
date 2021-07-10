using System;
using System.Globalization;

namespace Uri1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio, n;
            
            // n = Pi
            n = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Usando a biblioteca Math
            area = n * Math.Pow(raio, 2);

            /* Sem utilizar biblioteca
            area = n * (raio * raio);
            */

            Console.WriteLine($"A={area:F4}",CultureInfo.InvariantCulture);
            Console.ReadLine();
        }
    }
}
