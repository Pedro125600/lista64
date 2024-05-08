namespace lista64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int[10];
            int[] v2 = new int[10];
            int[] v3 = new int[20];

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                v2[i] = r.Next(100);
                v1[i] = r.Next(100);


            }


            for (int i = 0;i < 10; i++)
            {
                
                        v3[i] = v1[i];
                    
                
            }

            for (int i = 10 , j = 0; i < 20; i++ , j++)
            {
                

                    v3[i] = v2[j];
                
                
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


            for (int i = 0; i < 20; i++)
            {
           
                Console.Write(v3[i] + " ");
            }


        }
    }

}
    

