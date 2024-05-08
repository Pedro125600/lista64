namespace lista64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[5];
            int[] y = new int[5];

            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {

                x[i] = r.Next(10);
                y[i] = r.Next(10);
            }

          

            Console.WriteLine("\nSoma entre x e y:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Soma do elemento {x[i]} de x com o elemento {y[i]} de y: {x[i] + y[i]}");
            }

            Console.WriteLine("\nProduto entre x e y:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Produto do elemento {x[i]} de x com o elemento {y[i]} de y: {x[i] * y[i]}");
            }

            Console.WriteLine("\nDiferença entre x e y:");

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                if (x[i] != y[j])
                {

                        Console.WriteLine($"Elemento {x[i]} de x não existe em y.");
                }
            }

            Console.WriteLine("\nIntersecção entre x e y:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    if (x[i] == y[j])
                    {
                        Console.WriteLine($"Elemento {x[i]} aparece em x e y.");
                    }
            }

            Console.WriteLine("\nUnião entre x e y:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Elemento {x[i]} de x.");
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    if (y[i] != x[j])
                    {

                        Console.WriteLine($"Elemento {y[i]} de y não existe em x.");
                    }
            }
        }
    }

}
    

