using System.Xml.Linq;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hozzunk létre egy N × M - es kétdimenziós tömböt(1 < N, M < 10), amit töltsünk fel véletlenszerűen
            //0 és 9 közötti értékekkel. Jelenítsük meg a képernyőn ennek a mátrixnak az elemeit.
            //Állítsuk elő a mátrix transzponáltját1, vagyis tükrözzük azt a főátlójára.
            //Példa
            //1 2 3
            //4 5 6
            //7 8 9
            //→
            //1 4 7
            //2 5 8
            //3 6 9
            //→
            //a b c d
            //e f g h
            //i j k l
            //→
            //a e i
            //b f j
            //c g k
            //d h l

            Random rnd = new Random();
            int[,] numbers = new int[3, 3];
            for (int i = 0; i < numbers.GetLength(0); ++i) 
            {
                for (int j = 0; j < numbers.GetLength(1); ++j) 
                {
                    numbers[i, j] = rnd.Next(10);
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.GetLength(0); ++i) 
            {
                for (int j = 0; j < numbers.GetLength(1); ++j) 
                {
                    Console.Write(numbers[j, i] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            char[,] chars = new char[4, 4];
            for (int i = 0; i < chars.GetLength(0); ++i)
            {
                for (int j = 0; j < chars.GetLength(1); ++j)
                {
                    chars[i, j] = (char)rnd.Next('a', 'z' + 1);
                    Console.Write(chars[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < chars.GetLength(0); ++i)
            {
                for (int j = 0; j < chars.GetLength(1); ++j)
                {
                    Console.Write(chars[j, i] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
