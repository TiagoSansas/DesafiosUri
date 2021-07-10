using System;
using System.Globalization;

namespace Uri1006
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Nesse exercicio pede novamente a media poderada onde A tem peso 2
             * B tem peso 3 e C tem peso 5
             * Onde o peso total e equivalente a 10
             */
            double A, B, C, MEDIA;

            A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            MEDIA = ((A * 2) + (B * 3) + (C * 5)) / 10;
            Console.WriteLine($"MEDIA = {MEDIA:F1}");

        }
    }
}
