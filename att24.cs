using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NALuno = new int[10];
            double[] AltAluno = new double[10];


            int maior = 0, menor = 0; 
            double altMaior = 0, altMenor = 0;


            Console.WriteLine($"De o numero do Aluno :");
            NALuno[0] = int.Parse(Console.ReadLine());

            Console.WriteLine($"De a altura deste Aluno :");
            AltAluno[0] = double.Parse(Console.ReadLine());

            altMaior = AltAluno[0];
            altMenor = AltAluno[0];


            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"De o numero do Aluno :");
                NALuno[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"De a altura deste Aluno :");
                AltAluno[i] = double.Parse(Console.ReadLine());

                if (altMaior < AltAluno[i] )
                {
                    altMaior = AltAluno[i];
                    maior = NALuno[i];
                }

                if (altMenor > AltAluno[i])
                {
                    altMenor = AltAluno[i];
                    menor = NALuno[i];
                }

            }


            Console.WriteLine($"O numero do aluno com a Maior altura e : {maior} e sua altura e : {altMaior}  ");
            Console.WriteLine($"O numero do aluno com a Menor altura e : {menor} e sua altura e : {altMenor}  ");


            Console.ReadLine();

        }
    }
}
