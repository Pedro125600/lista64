using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] vetor = new int[5];

            Random r = new Random();
            vetor[0] = r.Next(100);

            int maior = vetor[0], menor = vetor[0], posicaoM = 0, poicaom = 0;  

            for (int i = 0; i < 5; i++)
            {
                vetor[i] = r.Next(100);


                if (maior < vetor[i])
                {
                    maior = vetor[i];
                    posicaoM = i;
                }

                if (menor > vetor[i])
                {
                    menor = vetor[i];
                    poicaom = i;
                }
                

            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Valor da posição {i} : {vetor[i]}");
            }

     
            Console.WriteLine($"\nA posição do maior valor e :{posicaoM} \n e a posição do menor valor e :{poicaom}");

            Console.ReadLine();

        }
    }
}
