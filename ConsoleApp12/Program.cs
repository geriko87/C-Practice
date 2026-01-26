namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Készítsünk programot, amely elkér a felhasználótól egy N pozitív egész számot, majd kiírja az egész számokat
            //0 és N között.Módosítsuk úgy a programot, hogy az csak a páros számokat írja ki.

            Console.Write("Enter any positive integer: ");
            int N = int.Parse(Console.ReadLine());

            //for (int i = 0; i < N; ++i) 
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 1; i < N; ++i)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
