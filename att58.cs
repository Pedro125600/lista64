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
            int[,] alunos = new int[5, 4];

            Random r = new Random();


            for (int i = 0; i < 5; i++)
            {
                alunos[i, 0] = r.Next(1, 11);
                alunos[i, 1] = r.Next(1, 11);
                alunos[i, 2] = r.Next(1, 11);
                alunos[i, 3] = alunos[i, 1] + alunos[i, 2];
            }

            Console.WriteLine("matriz :");
            ExibirMatriz(alunos);

            int maiorNotaFinal = alunos[0, 3];
            int matriculaMaiorNota = alunos[0, 0];

            for (int i = 1; i < 5; i++)
            {
                if (alunos[i, 3] > maiorNotaFinal)
                {
                    maiorNotaFinal = alunos[i, 3];
                    matriculaMaiorNota = alunos[i, 0];
                }
            }
            int somaNotasFinais = 0;
            for (int i = 0; i < 5; i++)
            {
                somaNotasFinais += alunos[i, 3];
            }
            double mediaNotasFinais = somaNotasFinais / 5.0;

            Console.WriteLine($"\nA matrícula do aluno com a maior nota final é: {matriculaMaiorNota}");

            Console.WriteLine($"A média aritmética das notas finais é: {mediaNotasFinais}");
        }
    }

}
    

    

