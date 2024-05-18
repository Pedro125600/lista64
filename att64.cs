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

        static int VerificarVencedor(int[,] matriz)
        {
            for (int i = 0; i < 3; i++)
            {
                if (matriz[i, 0] != 0 && matriz[i, 0] == matriz[i, 1] && matriz[i, 1] == matriz[i, 2])
                {
                    return matriz[i, 0];
                }
            }

            for (int j = 0; j < 3; j++)
            {
                if (matriz[0, j] != 0 && matriz[0, j] == matriz[1, j] && matriz[1, j] == matriz[2, j])
                {
                    return matriz[0, j];
                }
            }

            if (matriz[0, 0] != 0 && matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2])
            {
                return matriz[0, 0];
            }
            if (matriz[0, 2] != 0 && matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
            {
                return matriz[0, 2];
            }

            return 0;
        }
    

        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];

            for (int i = 0;i < 9; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine("Joador 1 - Sua Vez");
                    ExibirMatriz(matriz);


                    Console.WriteLine("Escolha uma casa na matriz selecionando uma linha e uma coluna");
                    Console.Write("Linha: ");
                    int l = int.Parse(Console.ReadLine());
                    Console.Write("Coluna: ");
                    int C = int.Parse(Console.ReadLine());

                    while (matriz[l, C] == 1 || matriz[l, C] == -1)
                    {
                        Console.WriteLine("Escolha uma casa na matriz selecionando uma linha e uma coluna VALIDA");
                        Console.Write("Linha: ");
                        l = int.Parse(Console.ReadLine());
                        Console.Write("Coluna: ");
                        C = int.Parse(Console.ReadLine());
                    }

                    matriz[l, C] = -1;

                }
                else
                {
                    Console.WriteLine("Joador 2 - Sua Vez");
                    ExibirMatriz(matriz);


                    Console.WriteLine("Escolha uma casa na matriz selecionando uma linha e uma coluna");
                    Console.Write("Linha");
                    int l = int.Parse(Console.ReadLine());
                    Console.Write("Coluna");
                    int C = int.Parse(Console.ReadLine());

                    while (matriz[l, C] == 1 || matriz[l, C] == -1)
                    {
                        Console.WriteLine("Escolha uma casa na matriz selecionando uma linha e uma coluna VALIDA");
                        Console.Write("Linha");
                        l = int.Parse(Console.ReadLine());
                        Console.Write("Coluna");
                        C = int.Parse(Console.ReadLine());
                    }

                    matriz[l,C] = 1;

                }
                
                if(VerificarVencedor(matriz) == 1)
                {
                    i = 100;
                    Console.WriteLine("O vencedor e o jogador 2 ");
                }

                if (VerificarVencedor(matriz) == 1)
                {
                    i = 100;
                    Console.WriteLine("O vencedor e o jogador 2 ");
                }
            }

          

        }
    }
}








