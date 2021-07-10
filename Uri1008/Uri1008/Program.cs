using System;
using System.Globalization;

namespace Uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumFuncionario, horasTrabalhadas;
            double ValorHora;

            NumFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            ValorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"NUMBER = {NumFuncionario}");
            Console.WriteLine($"SALARY = U$ {horasTrabalhadas * ValorHora:F2}",CultureInfo.InvariantCulture);
        }
    }
}
