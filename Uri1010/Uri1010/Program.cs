using System;
using System.Globalization;

namespace Uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores  = Console.ReadLine().Split(' ');
            int CodigoPeca, NumeroPeca;
            double ValorUnitario,ValorPagar;

            string[] valores2 = Console.ReadLine().Split(' ');
            int CodigoPeca2, NumeroPeca2;
            double ValorUnitario2;
            // PECA 1
            CodigoPeca = int.Parse(valores[0]);
            NumeroPeca = int.Parse(valores[1]);
            ValorUnitario = double.Parse(valores[2], CultureInfo.InvariantCulture);
             // PECAS 2
            CodigoPeca2 = int.Parse(valores2[0]);
            NumeroPeca2 = int.Parse(valores2[1]);
            ValorUnitario2 = double.Parse(valores2[2], CultureInfo.InvariantCulture);

            ValorPagar = (NumeroPeca * ValorUnitario) + (NumeroPeca2 * ValorUnitario2);

            Console.WriteLine($"VALOR A PAGAR: R$ {ValorPagar:F2}");
        }
    }
}
