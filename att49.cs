using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att49
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

        static void Main(string[] args)
        {

            int[,] matriz = new int[3, 3];
            Random r = new Random();
            int soma = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = r.Next(10);
                }

            }

            for (int i = 0 , j = 0; i < 3; i++ , j++)
            {
                
                    soma += matriz[i, j];
              
                
            }

            Console.WriteLine("Matriz");
            ExibirMatriz(matriz);
            Console.WriteLine($"A soma e : {soma}");


            Console.ReadLine();
        }
    }
}
