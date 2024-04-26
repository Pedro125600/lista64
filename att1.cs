using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista64
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = { 1, 0, 5, -2, -5, 7 };

            int v1 = A[0] + A[5] + A[1];

            A[4] = 100;

            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Vetor em posição {i} valor armazenada { A[i] }");
            }

            Console.ReadLine();
        }
    }
}
