using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nota = new int[15];

            for(int i = 0; i < 15; i++ )
            {
                Console.Write($"O valor da nota do {i + 1} aluno :");
                nota[i] = int.Parse(Console.ReadLine());
            }

            int soma = 0;

            for (int i = 0; i < 15; i++)
            {
               soma += nota[i];
            }

            int media = soma / 15;

            Console.WriteLine("A media das notas e : " + media);

            Console.ReadLine();
        }
    }
}
