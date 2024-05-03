using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];


            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                vetor[i] = r.Next(-10,10);

            

            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Valor da posição {i} : {vetor[i]}");
            }


            Console.WriteLine("Atribuindo valor 0 aos elementos com numero negativo");

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] < 0)
                {
                    vetor[i] = 0;
                }
                Console.WriteLine($"Valor da posição {i} : {vetor[i]}");
            }

            Console.ReadLine();
        }
    }
}
