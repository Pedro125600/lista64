using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att37
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[11];
            int temp = 0;
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                vetor[i] = r.Next(100);
            }

            Console.WriteLine("Vetor:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(vetor[i] + " ");
            }

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                for (int j = 0; j < vetor.Length - 1; j++)
                {
                    if (i <= 5)
                    {
                        if (vetor[j] > vetor[j + 1])
                        {
                            temp = vetor[j];
                            vetor[j] = vetor[j + 1];
                            vetor[j + 1] = temp;
                        }
                    }

                    else
                    {

                        if (vetor[j] < vetor[j + 1])
                        {
                            temp = vetor[j];
                            vetor[j] = vetor[j + 1];
                            vetor[j + 1] = temp;
                        }
                    }
                  
                }
            }

            Console.WriteLine("\nVetor ordenado:");
            for (int i = 0; i < 11; i++)
            {
                Console.Write(vetor[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
