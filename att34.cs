using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att34
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[10];



           for(int i = 0; i < 10; i ++)
            {
                Console.Write($"De o valor da {i + 1 } posição do vetor :");
               int n = int.Parse(Console.ReadLine());

                for(int j = 0; j < 10; j++)
                {
                    while(n == vetor[j])
                    {
                        Console.WriteLine("valor Repedido , de outro !");
                        Console.Write($"De o valor da {i + 1 } posição do vetor :");
                        n = int.Parse(Console.ReadLine());

                    }
                }


                vetor[i] = n;
            }

            Console.WriteLine("Vetor");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(vetor[i] + " ");
            }


            Console.ReadLine();
        }
    }
}
