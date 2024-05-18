namespace lista64
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];

            Console.WriteLine("Por favor, entre com os números para a matriz 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[] somaColunas = new int[3];

            for (int j = 0; j < 3; j++)
            {
                int soma = 0;
                for (int i = 0; i < 3; i++)
                {
                    soma += matriz[i, j];
                }
                somaColunas[j] = soma;
            }




            Console.WriteLine("O array com a soma das colunas é:");
            for (int i = 0; i < somaColunas.Length; i++)
            {
                Console.WriteLine($"Posição {i}: {somaColunas[i]}");
            }
        }
    }
}
    

