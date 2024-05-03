using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[10];
            int[] vetorB = new int[10];
            int[] vetorC = new int[20];

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                vetorA[i] = r.Next(100);
                vetorB[i] = r.Next(100);

            }
            int conA = 0, contB = 0;

            for(int i = 0; i < 20; i++)
            {

                if (i % 2 == 0)
                {
                    vetorC[i] = vetorA[conA];
                    conA++;
                }

                else
                {
                    vetorC[i] = vetorB[contB];
                    contB++;
                }
            }


       
            for (int i = 0; i < 20; i++)
            {
               
                Console.WriteLine($"\nValor da posição {i} do vetorC : {vetorC[i]}");
            }

            Console.ReadLine();
        }
    }
}
