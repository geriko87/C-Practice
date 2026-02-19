namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Írjunk programot, amely meghatározza egy szövegben a betűk, a számjegyek és a magánhangzók számát
            //kategóriánként.

            Console.WriteLine("Add meg a szöveget:");
            Console.WriteLine();
            string input = Console.ReadLine();

            string vowels = "aAáÁeEéÉiIíÍoOóÓöÖőŐuUúÚüÜűŰ";
            int letterCount = 0;
            int digitCount = 0;
            int vowelCount = 0;

            foreach (char c in input) 
            {
                if (char.IsLetter(c))
                {
                    letterCount++;
                    if (vowels.Contains(c))
                    {
                        vowelCount++;
                    }
                }
                else if (char.IsDigit(c))
                {
                    digitCount++;
                }

            }
            Console.WriteLine($"\nA megadott szöveg tartalmaz {digitCount} számot, {letterCount} betűt " +
                $"és abból {vowelCount} magánhangzót");
            Console.ReadLine();
        }
    }
}
