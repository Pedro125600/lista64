using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att8
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[6];
            Random r = new Random();
 

            for (int i = 0; i < 6; i++)
            {
                vetor[i] = r.Next(10);
            }



            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine($"Valor da posição {i} : {vetor[i]}");

            }

            Console.ReadLine();
        }
    }
}
