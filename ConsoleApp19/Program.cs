namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Készítsük programot, amely kiírja a képernyőre a szorzótáblát az alábbihoz hasonlóan.

            for (int i = 1; i < 10; ++i) 
            {
                for (int j = 1; j < 10; ++j) 
                {
                    Console.Write($"{i * j, 2}");
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
