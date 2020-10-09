using System;
using MathNet.Numerics;

namespace CoeficienteBinomial
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Calcula o coeficiente binonmial
            Console.WriteLine("1. Calcular o coeficiente binomial ");
            while (true)
            {
                Console.WriteLine("Informe um número de 1 a 100 ( 999 -> Sai )");
                string input = Console.ReadLine();
                int n;
                if (Int32.TryParse(input, out n))
                {
                    if (n == 999)
                    {
                        break;
                    }
                    Console.WriteLine(SpecialFunctions.Binomial(10, 8).ToString("N"));
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Valor inválido...");
                }
            }
            Console.WriteLine("Pressione algo para encerrar...");
            Console.ReadLine();
        }
    }
}
