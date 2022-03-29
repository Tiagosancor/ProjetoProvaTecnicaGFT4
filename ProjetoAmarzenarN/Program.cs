using System;
using System.Globalization;

namespace ProjetoAmarzenarN
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];


            for (int i = 0; i < N; i++)
            {
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (!Array.Exists(vet, d => d == valor))
                {
                    vet[i] = valor;
                }
            }

            for (int i = 0; i < N; i++)
            {
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (!Array.Exists(vet, d => d == valor))
                {
                    vet[i] = valor;
                    Array.Sort(vet);
                }
            }
        }
    }
}
