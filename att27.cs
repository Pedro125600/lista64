namespace lista64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
         
            Random r = new Random();

            for(int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = r.Next(100);
            }
        
            for(int i = 0;i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0 && vetor[i] % 3 != 0 && vetor[i] % 5 != 0 || vetor[i] == 2 || vetor[i] == 1 || vetor[i] == 3)
                {
                    Console.WriteLine($"O valor {vetor[i]} e primo e sua posoção e {i}");
                }
            }



        }
    }

}
    

