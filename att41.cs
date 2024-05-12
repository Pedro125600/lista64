namespace lista64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j )
                    {
                        matriz[i, j] = 1;
                    }

                    else
                    {
                        matriz[i, j] = 0;
                    }

                    Console.Write(matriz[i, j] + " ");
                }

                Console.WriteLine("\n");
            }

        }
    }
}
    

