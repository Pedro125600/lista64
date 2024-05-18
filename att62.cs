namespace lista64
{
    internal class Program
    {
        static void ExibirMatriz(double[,] matriz)
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
            Random rand = new Random();
            double[,] matrizA = new double[3, 3];
            double[,] matrizB = new double[3, 3];

           
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizA[i, j] = rand.Next(1, 10); 
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizB[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        matrizB[i, j] += matrizA[i, k] * matrizA[k, j];
                    }
                }
            }

            Console.WriteLine("A matriz A é:");
            ExibirMatriz(matrizA);

            Console.WriteLine("A matriz B = A^2 é:");
            ExibirMatriz(matrizB);
        }
    }
}








