using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] vetorA = new int[10];
            int negativo = 0 , soma = 0;

            for (int i = 0; i < 10; i++)
            {
                vetorA[i] = r.Next(-100 , 100);
                if (vetorA[i] >= 0)
                {
                    soma += vetorA[i];
                }
                else
                {
                    negativo++;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Valor da posição {i} : {vetorA[i]}");
            }

            Console.WriteLine($"NUmeros negativos : {negativo} ");
            Console.WriteLine($"Numeros soma dos positivos : {soma}");
            Console.ReadLine();

        }
    }
}
