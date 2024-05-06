namespace lista64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[6];
            int somaPares = 0;
            int qtdImpares = 0;

            Console.WriteLine("Digite 6 números inteiros:");

        
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());

                // Verificar se o número é par
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine($"Número {numeros[i]} é par.");
                    somaPares += numeros[i]; 
                }
                else
                {
                    Console.WriteLine($"Número {numeros[i]} é ímpar.");
                    qtdImpares++;
                }
            }

            Console.WriteLine($"Soma dos números pares: {somaPares}");
            Console.WriteLine($"Quantidade de números ímpares: {qtdImpares}");
        }
    }

}
    

