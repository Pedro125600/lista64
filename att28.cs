namespace lista64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];
            int[] v1 = new int[10];
            int[] v2 = new int[10];

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                v[i] = r.Next(100);

                if (v[i] % 2 == 0)
                {
                    v2[i] = v[i];
                }
                else
                {
                    v1[i] = v[i];
                }
            }

            Console.WriteLine("Vetor 1 Impares ");

         


            for (int i = 0;i < 10;i++)
            {
                if (v1[i] != 0)
                Console.Write(v1[i] + " ");
            }


            Console.WriteLine("\nVetor 2 Pares ");

            for (int i = 0; i < 10; i++)
            {
                if (v2[i] != 0)
                    Console.Write(v2[i] + " ");
            }


        }
    }

}
    

