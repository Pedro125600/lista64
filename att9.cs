using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[6];
            Random r = new Random();
            int n1 = 0;

            for (int i = 0; i < 6; i++)
            {
                n1 = r.Next(100);
               if (n1 % 2 == 0)
                {
                    vetor[i] = n1;
                }
                else
                {
                    i--;
                }
               
            }

            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine($"Valor da posição {i} : {vetor[i]}");

            }

            Console.ReadLine();

        }
    }
}
