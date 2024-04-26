using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] vetorA = new int[10];

            for (int i = 0; i < 10; i++)
            {
                vetorA[i] = r.Next(10);
            }


            Console.WriteLine("Vetor A");


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Valor da posição {i} : {vetorA[i]}");
            }


            double[] vetorB = new double[10];

            Console.WriteLine("\nVetor B");
            for(int i = 0; i < 10; i++)
            {
                vetorB[i] = Math.Pow(vetorA[i],2);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Valor da posição {i} : {vetorB[i]}");
            }

            Console.ReadLine();

        }
    }
}
