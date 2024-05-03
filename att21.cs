using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[10];
            int[] vetorB = new int[10];
            int[] vetorC = new int[10];

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                vetorA[i] = r.Next(100);
                vetorB[i] = r.Next(100);
                vetorC[i] = vetorA[i] - vetorB[i];
            }


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{vetorA[i]} - {vetorB[i]} = {vetorC[i]}");
            }


            Console.ReadLine();

        }
    }
}
