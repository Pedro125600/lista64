using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att35
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o primeiro número (positivo menor que 10000): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número (positivo menor que 10000): ");
            int b = int.Parse(Console.ReadLine());
           
            int[] vetorA = new int[4];
            int[] vetorB = new int[4];
            int[] vetorSoma = new int[4];


            for (int i = 0; i < 4; i++)
            {
        
                vetorA[i] = a % 10;
                a /= 10;
            }

            Console.WriteLine("Vetor A");

            for(int i = 0; i < vetorA.Length ; i++)
            {
                Console.Write(vetorA[i] + " ");
            }

            for (int i = 0; i < 4; i++)
            {

                vetorB[i] = b % 10;
                b /= 10;
            }

            Console.WriteLine("\nVetor B");

            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.Write(vetorB[i] + " ");
            }

            int  mais1= 0;
            for (int i = 0; i < 4; i++)
            {
                int soma = vetorA[i] + vetorB[i] + mais1;
                if (soma >= 10)
                {
                    vetorSoma[i] = soma % 10;
                    mais1 = 1;
                }
                else
                {
                    vetorSoma[i] = soma;
                    mais1 = 0; 
                }
            }


            Console.WriteLine("\nVetor Soma:");

            for (int i = 0; i < vetorSoma.Length; i++)
            {
                Console.Write(vetorSoma[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
