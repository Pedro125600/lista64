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
            double[,] matriz1 = new double[2,2];
            double[,] matriz2 = new double[2,2];

            Console.WriteLine("Entre com os valores para a primeira matriz 2x2:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz1[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Entre com os valores para a segunda matriz 2x2:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz2[i, j] = double.Parse(Console.ReadLine());
                }
            }

            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("(1) Somar as duas matrizes");
                Console.WriteLine("(2) Subtrair a primeira matriz da segunda");
                Console.WriteLine("(3) Adicionar uma constante às duas matrizes");
                Console.WriteLine("(4) Imprimir as matrizes");
                Console.WriteLine("(5) Sair");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        double[,] soma = new double[2,2];
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                soma[i, j] = matriz1[i, j] + matriz2[i, j];
                            }
                        }
                        Console.WriteLine("A soma das duas matrizes é:");
                        ExibirMatriz(soma);
                        break;

                    case 2:
                        double[,] subtracao = new double[2,2];
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                subtracao[i, j] = matriz2[i, j] - matriz1[i, j];
                            }
                        }
                        Console.WriteLine("A subtração da primeira matriz da segunda é:");
                        ExibirMatriz(subtracao);
                        break;

                    case 3:
                        Console.Write("Digite a constante a ser adicionada: ");
                        double constante = double.Parse(Console.ReadLine());
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                matriz1[i, j] += constante;
                                matriz2[i, j] += constante;
                            }
                        }
                        Console.WriteLine("Primeira matriz:");
                        ExibirMatriz(matriz1);
                        Console.WriteLine("Segunda matriz:");
                        ExibirMatriz(matriz2);
                        break;

                    case 4:
                        Console.WriteLine("Primeira matriz:");
                        ExibirMatriz(matriz1);
                        Console.WriteLine("Segunda matriz:");
                        ExibirMatriz(matriz2);
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }
        }
    }
}

    

    

    

