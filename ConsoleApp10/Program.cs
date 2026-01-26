namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kérjünk egy a felhasználótól egy betűt, majd írjuk ki, hogy magánhangzót vagy mássalhangzót adott-e meg.

            Console.Write("Enter a letter: ");
            char letter = char.Parse(Console.ReadLine());

            string vowels = "aAáÁeEéÉiIíÍoOóÓöÖőŐuUúÚüÜűŰ";
            string consonants = "bBcCdDfFgGhHjJkKlLmMnNpPrRsStTwWqQyYxX";

            if (vowels.Contains(letter))
            {
                Console.WriteLine("The given letter is a vowel.");
            }
            else if (consonants.Contains(letter))
            {
                Console.WriteLine("The given letter is a consonant.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error! You entered an invalid character!");
            }
            Console.ReadLine();
        }
    }
}
