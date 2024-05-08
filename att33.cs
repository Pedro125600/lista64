namespace lista64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[15];

            Random r = new Random();

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = r.Next(0,5);
            }

            Console.WriteLine("Vetor");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }


            int novaPosicao = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != 0)
                {
                    x[novaPosicao] = x[i];
                    novaPosicao++;
                }
            }

            for (int i = novaPosicao; i < x.Length; i++)
            {
                x[i] = 0;
            }

            Console.WriteLine("Vetor Compactado");
            for(int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }



    }
    }
}
    

