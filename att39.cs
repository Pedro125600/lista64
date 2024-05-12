namespace lista64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de linhas para o Triângulo de Pascal:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int coeficiente = 1; 
                for (int j = 0; j <= i; j++)
                {
                  
                    Console.Write(coeficiente + " ");

                   
                    coeficiente = coeficiente * (i - j) / (j + 1);
                }
                Console.WriteLine("\n"); 
            }


        }
    }
}
    

