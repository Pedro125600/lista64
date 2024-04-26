using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            Random r = new Random();
            int par = 0;

            for (int i = 0; i < 10; i++)
            {
                vetor[i] = r.Next(100);
                if (vetor[i] % 2 == 0)
                {
                    par++;
                }

            }

            

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Valor da posição {i} : {vetor[i]}");

            }

            Console.WriteLine($"O vator possui {par} numeros pares ");


            Console.ReadLine();

        }
    }
}
