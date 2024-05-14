using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att52
{
    class Program
    {
        static void ExibirMatriz(int[,] matriz)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + "  ");
                }
                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {

            int[,] matriz = new int[4,4];
            Random r = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = r.Next(1,20);
                }

            }

            Console.WriteLine("Matriz");
            ExibirMatriz(matriz);

            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    matriz[i, j] = 0;
                }
            }

          
            Console.WriteLine($"\n A matriz atribuindo zero a todos os elementos acima da diagonal principal");
            ExibirMatriz(matriz);

            Console.ReadLine();

        }
    }
}
