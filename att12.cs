using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[5];

            Random r = new Random();
            vetor[1] = r.Next(100);

            int maior = vetor[1], menor = vetor[1] , soma = 0 , media = 0;

            for (int i = 1; i < 5; i++)
            {
                vetor[i] = r.Next(100);


                if (maior < vetor[i])
                {
                    maior = vetor[i];
                }

                if (menor > vetor[i])
                {
                    menor = vetor[i];
                }
                soma += vetor[i];

            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Valor da posição {i} : {vetor[i]}");
            }

            media = soma / 5;
            Console.WriteLine($"\nO maior valor e : {maior} \n O menor valor e : {menor} \n A media e : {media}");

            Console.ReadLine();

        }
    }
}
