using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att53
{
    class Program
    {
        static void ExibirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "  ");
                }
                Console.WriteLine("\n");
            }
        }

        static  int RepetirValores(int[,] matriz , int n)
        {
            Random r = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (n == matriz[i,j])
                    {
                        n = r.Next(0, 99);
                        i = 0;
                        j = 0;
                    }
                }
        
            }

            return n;
        }

        static void Main(string[] args)
        {
            int[,] matriz = new int[5,5];
            Random r = new Random();

            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    int n = r.Next(0, 99);
                    matriz[i, j] = RepetirValores(matriz, n);
                }
            }

        

            Console.WriteLine($"O valor da Matriz e: ");
            ExibirMatriz(matriz);

            Console.ReadLine();
        }
    }
}
