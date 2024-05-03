using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att23
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] X = new double[5];
            double[] Y = new double[5];

            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                X[i] = r.Next(100);
                Y[i] = r.Next(100);

            }

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine($"Valor da posição {i} do vetor X : {X[i]}");
            }

            Console.WriteLine($" ");


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Valor da posição {i} do vetor Y : {Y[i]}");
            }


            double escalar = 0;

            for (int i = 0; i < 5; i++)
            {
                escalar += X[i] * Y[i] + X[i] / 2 + Y[i] / 2;
            }

            Console.WriteLine($"\nO produto escalar e : {escalar} ");
            Console.ReadLine();
        }
    }
}
