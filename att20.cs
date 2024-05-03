using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att20
{
    class Program
    {
        static void Main(string[] args)
        {



            int[] vetorA = new int[10];


            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                vetorA[i] = r.Next(0,50);

            }

            int[] vetorB = new int[10];


            for (int i = 0; i < 10; i++)
            {
               if (vetorA[i] % 2 != 0)
                {
                    vetorB[i] = vetorA[i];
                }

            }

            Console.WriteLine("VetorA  VetorB");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{vetorA[i]}       {vetorB[i]}");
            }

            Console.ReadLine();
        }
    }
}
