using System;

namespace att56
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
            int[,] provas = new int[10, 3];
            Random r = new Random();

            Console.WriteLine("Provas");

            for (int i = 0; i < provas.GetLength(0); i++)
            {
                for (int j = 0; j < provas.GetLength(1); j++)
                {
                    provas[i, j] = r.Next(0, 11);
                }
            }

            int[] PiorNotas = new int[3];
            int menornota;

            for (int i = 0; i < 3; i++)
            {
                menornota = provas[0, i]; 

                for (int j = 0; j < 10; j++)
                {
                    if (provas[j, i] < menornota)
                    {
                        menornota = provas[j, i];
                        PiorNotas[i] = j;
                    }
                }
            }

            Console.WriteLine("Provas");
            ExibirMatriz(provas);

            Console.WriteLine("\nAluno cuja pior nota foi na prova 1: " + (PiorNotas[0] + 1));
            Console.WriteLine("Aluno cuja pior nota foi na prova 2: " + (PiorNotas[1] + 1));
            Console.WriteLine("Aluno cuja pior nota foi na prova 3: " + (PiorNotas[2] + 1));

            Console.ReadLine();
        }
    }
}
