using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[50];




            for (int i = 0; i < 50; i++)
            {
                vetor[i] = (i + 5 * i) % (i + 1);

            }

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Valor da posição {i} : {vetor[i]}");
            }

            Console.ReadLine();
        }
    }
}
