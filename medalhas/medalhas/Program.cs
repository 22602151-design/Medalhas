namespace medalhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] medalhas = new int[10, 3];
            int i, j;
            int maior = 0;
            string campeao = "";
            string[] paises = new string[10] { "BRA", "EUA", "ALE", "AFS", "FRA", "BEL", "ITA", "ISR", "URU", "ARG" };
            int[] somaMedalhas = new int[10];

            Random numero = new Random();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("\tOURO\tPRATA\tBRONZE\t\tTOTAL");
            Console.WriteLine("--------------------------------------------------");

            for (i = 0; i < 10; i++)
            {
                Console.Write(paises[i]);
                for (j = 0; j < 3; j++)
                {
                    medalhas[i, j] = numero.Next(51);
                    somaMedalhas[i] += medalhas[i, j];
                    Console.Write("\t" + medalhas[i, j]);
                }

                Console.Write("\t ->");
                Console.Write($" \t{somaMedalhas[i]}");
                Console.Write("\n");

                if (medalhas[i, 0] > maior)
                {
                    maior = medalhas[i, 0];
                    campeao = paises[i];
                }
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine($"País campeão (maior números de medalhas de ouro): {campeao}");
            Console.ReadKey();
        }


    }
}
        
    

