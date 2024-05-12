namespace lista64
{
    internal class Program
    {
        static void ExibirMatriz(int[,] matriz)
        {
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine(); 
            }
        }

        static void Main(string[] args)
        {

            int[,] matriz = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i < j)
                    {
                        matriz[i, j] = 2 * i + 7 * j - 2;
                    }
                    else if (i == j)
                    {
                        matriz[i, j] = 3 * i * i - 1;
                    }
                    else
                    {
                        matriz[i, j] = 4 * i * i * i - 5 * j * j + 1;
                    }
                }
            }

            Console.WriteLine("Matriz");
            ExibirMatriz(matriz);
          

        }
    }
}
    

