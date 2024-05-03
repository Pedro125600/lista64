using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att18
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[10];


            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                vetor[i] = r.Next(100);
            }

            Console.WriteLine("Escolha o valor de X");
            int x = int.Parse(Console.ReadLine());


            Console.WriteLine($"Os numeros que são multiplos de {x} são ");
            int cont = 0;
            for (int i = 0; i < 10; i++)
            {
               if (vetor[i] % x == 0)
                {
                    cont++;
                    Console.WriteLine($"Valor da posição {i} : {vetor[i]}");

                }

            }

            Console.WriteLine($"Elas são {cont} numeros");

            Console.ReadLine();
        }
    }
}
