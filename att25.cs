namespace lista64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[100];
            int cont = 0;
            int n = 1;

            while (cont < 100)
            {
                if (n % 7 != 0 && n % 10 != 7)
                {
                    vetor[cont] = n;
                    cont++;
                }
                n++;
            }

            for(int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i] + " ");
            }



        }
    }

}
    

