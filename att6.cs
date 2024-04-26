using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            Console.Write("De o 1 valor do vetor : ");
            vetor[1] = int.Parse(Console.ReadLine());

            int maior = vetor[1], menor = vetor[1];

            for(int i = 1; i < 10; i++)
            {
                Console.Write($"De o {i + 1} valor do vetor : ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (maior < vetor[i])
                {
                    maior = vetor[i];
                }

                if (menor > vetor[i])
                {
                    menor = vetor[i];
                }
            }


            Console.WriteLine($"O maior valor e : {maior} \n o menor valor e : {menor} ");

            Console.ReadLine();
        }


    }
}
