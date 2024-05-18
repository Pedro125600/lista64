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
                double[,] matrizA = new double[3, 3];
                double[,] matrizB = new double[3, 3];
                double[,] matrizC = new double[3, 3];

                Console.WriteLine("Entre com os valores para a primeira matriz 3x3 (A):");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Elemento [{i},{j}]: ");
                        matrizA[i, j] = double.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Entre com os valores para a segunda matriz 3x3 (B):");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Elemento [{i},{j}]: ");
                        matrizB[i, j] = double.Parse(Console.ReadLine());
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        matrizC[i, j] = 0;
                        for (int k = 0; k < 3; k++)
                        {
                            matrizC[i, j] += matrizA[i, k] * matrizB[k, j];
                        }
                    }
                }

                Console.WriteLine("A matriz resultante C = A * B é:");
                ExibirMatriz(matrizC);
            }
        }
    }


    

    

    

