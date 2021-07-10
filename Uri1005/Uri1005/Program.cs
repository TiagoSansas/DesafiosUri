using System;
using System.Globalization;

namespace Uri1005
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesse problema utiliza-se a media podera onde A tem peso 3.5 e B tem peso 7.5

            double A, B, MEDIA;
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = ((A*3.5)+(B*7.5))/11;

            Console.WriteLine($"MEDIA = {MEDIA:F5}");


        }
    }
}
