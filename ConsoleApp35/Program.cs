using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Írjunk programot, amely képes adott számú, különböző, az előző feladatban megadott formátumú véletlen
            //rendszámot generálni.
            
            Console.Write("Hány rendszámot szeretnél: ");
            int numberOfPlates = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPlates; ++i) 
            {
                Console.WriteLine($"{LetterGenerator()}{LetterGenerator()} {LetterGenerator()}{LetterGenerator()}" +
                    $" - {DigitGenerator()}{DigitGenerator()}{DigitGenerator()}");
            }
            Console.ReadLine();
        }

        static Random rnd = new Random();
        static char LetterGenerator() 
        {
            return (char)rnd.Next('A', 'Z' + 1);
        }
        static int DigitGenerator() 
        {
            return rnd.Next(10);
        }
    }
}
