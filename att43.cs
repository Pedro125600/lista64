namespace lista64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];
            int maior = 0;
            int linha = 0;
            int coluna = 0;

            Random r = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = r.Next(11);
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                        linha = i;
                        coluna = j;
                    }
                    Console.Write(matriz[i, j] + " ");
                }

                Console.WriteLine("\n");
            }

            Console.WriteLine($"O maior valor esta na linha {linha + 1} e na coluna {coluna + 1}");

        }
    }
}
    

