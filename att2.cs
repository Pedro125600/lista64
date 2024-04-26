using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[6];

            for(int i  = 0; i < 6; i++)
            {
                Console.Write($"De o {i + 1} : ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < 6; i++ )
            {
                Console.WriteLine($"Valor da posição {i} : {vetor[i]}");
            }

            Console.ReadLine();
        }
    }
}
