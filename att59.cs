namespace lista64
{
    internal class Program
    {
        static void ExibirMatriz(int[,] matriz)
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
            int[,] matriz = new int[3, 6];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Random r = new Random();

                    matriz[i, j] = r.Next(100);
                }
            }

            Console.WriteLine("\nA matriz:");
            ExibirMatriz(matriz);

            int somaImpares = 0;
          for(int i = 0; i < 3; i++)
            {
                for(int j = 1; j < 6; j+=2)
                {
                    somaImpares += matriz[i, j];
                }
            }
                   
                
            
            Console.WriteLine($"\nA soma de todos os elementos das colunas ímpares é: {somaImpares}");

            int somaSegundaColuna = 0;
            int somaQuartaColuna = 0;
            for (int i = 0; i < 3; i++)
            {
                somaSegundaColuna += matriz[i, 1];
                somaQuartaColuna += matriz[i, 3];
            }
            int media = (somaSegundaColuna + somaQuartaColuna) / 6;
            Console.WriteLine($"A média aritmética dos elementos da segunda e quarta colunas é: {media}");

            for (int i = 0; i < 3; i++)
            {
                matriz[i, 5] = matriz[i, 0] + matriz[i, 1];
            }

            Console.WriteLine("\nA matriz modificada é:");
            ExibirMatriz(matriz);
        }
    }

}
    

    

