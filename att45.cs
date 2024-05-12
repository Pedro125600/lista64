namespace lista64
{
    internal class Program
    {
        static void ExibirMatriz(int[,] matriz)
        {
            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine(); 
            }
        }

        static void Main(string[] args)
        {
            int[,] matriz1 = new int[4, 4];
            int[,] matriz2 = new int[4, 4];
            int[,] matriz3 = new int[4, 4];
            

            Random r = new Random();

          
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    matriz1[i, j] = r.Next(101);
                    matriz2[i, j] = r.Next(101);

                    if (matriz1[i, j] > matriz2[i,j])
                    {
                        matriz3[i , j] = matriz1[i,j];
                    }

                    else
                    {
                        matriz3[i, j] = matriz2[i, j];

                    }
                }

            }

            Console.WriteLine("Matriz 1");
            ExibirMatriz(matriz1);
            Console.WriteLine("\nMatriz 2");
            ExibirMatriz(matriz2);
            Console.WriteLine("\nMatriz 3");
            ExibirMatriz(matriz3);

        }
    }
}
    

