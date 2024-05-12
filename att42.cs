namespace lista64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = i * j;
                    Console.Write(matriz[i, j] + " ");
                }

                Console.WriteLine("\n");
            }

        }
    }
}
    

