using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            Console.Write("De o 1 valor do vetor na posoção 0 :");
            vetor[1] = int.Parse(Console.ReadLine());

            int maior = vetor[0], posicao = 0;

            for (int i = 1; i < 10; i++)
            {
                Console.Write($"De o {i + 1} valor do vetor na posoção {i} : ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (maior < vetor[i])
                {
                    maior = vetor[i];
                    posicao = i;
                }

            }

            Console.WriteLine($"O maior valor e {maior} na posição {posicao}");

            Console.ReadLine();

        }
    }
}


