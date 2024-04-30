using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[5];
   

            Random r = new Random();
          
            for (int i  = 0; i < 5; i++)
            {
                vetor[i] = r.Next(10);
            
            }

            Console.WriteLine($"Escolha uma opção \n 0:finalize o programa;\n 1: mostre o vetor na ordem direta;\n 2: mostre o vetor na ordem inversa");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Valor da posição {i} : {vetor[i]}");
                    }
                    break;
                case 2:
                    for (int i = 4; i >= 0; i--)
                    {
                        Console.WriteLine($"Valor da posição {i} : {vetor[i]}");
                    }
                    break;
                case 0: break;
                default: Console.WriteLine("codigo e invalido");break;
            }




          

            Console.ReadLine();
        }

    
    }
}
