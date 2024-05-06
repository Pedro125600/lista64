namespace lista64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int[10];
            int[] v2 = new int[10];
            int[] v3 = new int[10];

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                v2[i] = r.Next(100);
                v1[i] = r.Next(100);


            }


            for (int i = 0;i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        v3[i] = v1[i];
                    }
                }
            }

            Console.WriteLine("Vetor 1 ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(v1[i] + " ");
            }

            Console.WriteLine("\nVetor 2 ");


            for (int i = 0; i < 10; i++)
            {
                Console.Write(v2[i] + " ");
            }
            Console.WriteLine("\nVetor 3 ");


            for (int i = 0; i < 10; i++)
            {
                if (v3[i] != 0)
                Console.Write(v3[i] + " ");
            }


        }
    }

}
    

