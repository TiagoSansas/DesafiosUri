using System;
using System.Globalization;

namespace Uri1012
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] valores = Console.ReadLine().Split(' ');
            double A, B, C;
            double TrianguloRetangulo, AreaDoCirculo, AreaTrapezio, AreaQuadrado, AreaRetangulo;
            A = double.Parse(valores[0],CultureInfo.InvariantCulture);
            B = double.Parse(valores[1],CultureInfo.InvariantCulture);
            C = double.Parse(valores[2],CultureInfo.InvariantCulture);

            TrianguloRetangulo = A * C / 2;
            AreaDoCirculo = Math.Pow(C, 2) * 3.14159;
            AreaTrapezio = (A + B) * C / 2;
            AreaQuadrado = Math.Pow(B, 2);
            AreaRetangulo = A * B;

            Console.WriteLine($"TRIANGULO: {TrianguloRetangulo:F3}");
            Console.WriteLine($"CIRCULO: {AreaDoCirculo:F3}");
            Console.WriteLine($"TRAPEZIO: {AreaTrapezio:F3}");
            Console.WriteLine($"QUADRADO: {AreaQuadrado:F3}");
            Console.WriteLine($"RETANGULO: {AreaRetangulo:F3}");
            
            
            


        }
    }
}
