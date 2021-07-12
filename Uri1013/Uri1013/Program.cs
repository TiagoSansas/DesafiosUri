using System;

namespace Uri1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int A, B, C , maior, maiorABC;

            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);
            C = int.Parse(valores[2]);

            maior = (A + B + Math.Abs(A - B)) / 2;
            maiorABC = (maior + C + Math.Abs(maior - C)) / 2;
            Console.WriteLine($"{maiorABC} eh o maior");

        }
    }
}
