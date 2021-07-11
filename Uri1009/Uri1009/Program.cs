using System;
using System.Globalization;

namespace Uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, totalDeVendas,comissao;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalDeVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comissao = (totalDeVendas / 100) * 15 + salario;

            Console.WriteLine($"TOTAL = R$ {comissao:F2}");

        }
    }
}
