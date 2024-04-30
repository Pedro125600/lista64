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

            int[] vetor = new int[20];
            int[] vetor2 = new int[20];

            Random r = new Random();
            vetor[0] = r.Next(10);
            vetor2[0] = vetor[0];

            for (int i = 1; i < 20; i++)
            {
                vetor[i] = r.Next(20);
                vetor2[i] = vetor[i];
            }

            for (int i = 0; i < 20; i++)
            {
                for (int j = i + 1; j < 20; j++)
                {
                    if (vetor[i] == vetor[j])
                    {
                        vetor[i] = r.Next(20);
                        i = -1; 
                        break;
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Valor da posição {i} : {vetor[i]}");
            }

            Console.ReadLine();
        }

    
    }
}
