﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att54
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gabarito = new int[10];
            int[] notas = new int[5];
            int[,] provas = new int[5, 10];

            Random r = new Random();

            Console.WriteLine("gabarito");

            for (int i = 0; i < gabarito.Length; i++)
            {
                gabarito[i] = r.Next(1, 5);
                Console.Write(gabarito[i] + " ");
            }

            Console.WriteLine("\nprovas");


            for (int i = 0; i < provas.GetLength(0); i++)
            {
                for (int j = 0; j < provas.GetLength(1); j++)
                {
                    provas[i, j] = r.Next(1, 5);

                    if (provas[i, j] == gabarito[j])
                    {
                        notas[i]++;
                    }


                }


            }

            for (int i = 0; i < provas.GetLength(0); i++)
            {


                for (int j = 0; j < provas.GetLength(1); j++)
                {
                    Console.Write(provas[i, j] + " ");

                }

                Console.WriteLine("\n");
            }

            Console.WriteLine("\n Notas");

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"O aluno {i + 1} tirou : {notas[i]} ");
   
            }


            Console.ReadLine();
        
    }
    }
}
