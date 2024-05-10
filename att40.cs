using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att40
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4,4];
            Random r = new Random();
            int cont = 0;


            for(int i = 0; i < 4; i ++)
            {
                for (int j = 0; j <  4; j++)
                {
                    matriz[i, j] = r.Next(20);
                    if (matriz[i,j] > 10)
                    {
                        cont++;
                    }
                }

            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine($"A matriz possui {cont} numeros maiores que 10 ");

            Console.ReadLine();
        }
    }
}
