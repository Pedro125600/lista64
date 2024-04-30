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
            
            int[] vetor = new int[10];

            Random r = new Random();

       
            for (int i = 0; i < 10; i++)
            {
                vetor[i] = r.Next(10);
            }


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Valor da posição {i} : {vetor[i]}");
            }


            for (int i = 0; i < 10; i++)
            {
                int p = vetor[i];
                for (int j = 0; j < 10; j++)
                {
                    if (p == vetor[j]  && i != j)
                    {
                        Console.WriteLine($"As posições {i} e {j} possuem valores iguais : o valor e {p}");
                    }
                }


            }




            Console.ReadLine();

        }
    }
}
