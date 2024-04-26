using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[8];
            Random r = new Random();

            for (int i = 0; i < 8; i++)
            {
                vetor[i] = r.Next(10);
            }

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Valor da posição {i} : {vetor[i]}");

            }


            Console.Write("Escolha um valor X correspondente a uma posição de um vetor :");
            int X = int.Parse(Console.ReadLine());

            Console.Write("Escolha um valor Y correspondente a uma posição de um vetor :");
            int Y = int.Parse(Console.ReadLine());

            int soma = vetor[X] + vetor[Y];

            Console.WriteLine($"A soma de {vetor[X]} + {vetor[Y]} = {soma} ");
            Console.ReadLine();
        }
    }
}
