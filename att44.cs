namespace lista64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5];
        Console.WriteLine("escolha um valor para buscar na matriz");
            int x = int.Parse(Console.ReadLine());
            int linha = 0;
            int coluna = 0;

            Random r = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = r.Next(101);
                    if (matriz[i, j] == x)
                    {
                    
                        linha = i + 1;
                        coluna = j + 1;
                    }
            
                    Console.Write(matriz[i, j] + " ");

                }

                Console.WriteLine("\n");
            }

            if (linha != 0 && coluna != 0)
                Console.WriteLine($"O valor X esta na linha {linha} e na coluna {coluna}");
            else Console.WriteLine("Valor não existe ");
        }
    }
}
    

