using System.Security.Cryptography;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Készítsünk programot, amely ciklusok használatával felsorolja a francia kártya lapjait egy tömbbe.
            //A lehetséges színek: Kőr, Káró, Treff és Pikk. A lapoknak 13 féle magassága lehet: számok 2 - től 10 - ig, majd
            //Jumbó, Dáma, Király és Ász.
            //Példa
            //Az 52 elemű tömb elemei tehát:
            //{ "Kőr 2", "Kőr 3", ..., "Kőr Király", "Kőr Ász", "Káró 2", "Káró 3", ...,
            //"Pikk Dáma", "Pikk Király", "Pikk Ász" }

            //Keverjük meg a korábban készített kártyapaklit a Fisher–Yates keveréssel. A módszer lényege, hogy a tömb
            //elemein végighaladva mindegyikhez kiválaszt egy véletlen helyen lévő elemet a korábban még nem vizsgáltak közül,
            //amelyeket utána megcserél. Az algoritmus pszeudokóddal az alábbi formában adható meg(1 - alapú indexelést
            //használva).
            //ciklus i ← 1 - től(n − 1) - ig
            //j ← véletlen egész; i ≤ j ≤ n
            //x[i] ↔ x[j]
            //ciklus vége

            Random rnd = new Random();

            string[] colours = { "Kör", "Káró", "Treff", "Pikk" };
            string[] types = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jumbó", "Dáma", "Király", "Ász" };

            string [] deckOfCards = new string[colours.Length * types.Length];
            int index = 0;

            Console.WriteLine("Before mixing: \n");
            for (int i = 0; i < colours.Length; ++i)
            {
                for (int j = 0; j < types.Length; ++j)
                {
                    deckOfCards[index] = $"{colours[i]} {types[j]}";
                    Console.WriteLine($"{colours[i]} {types[j]}");
                    index++;
                }
            }
            Console.WriteLine();

            Console.WriteLine("After mixing: \n");
            for (int i = 0; i < deckOfCards.Length; ++i)
            {
                int j = rnd.Next(i, deckOfCards.Length);

                string temp = deckOfCards[i];
                deckOfCards[i] = deckOfCards[j];
                deckOfCards[j] = temp;

                Console.WriteLine(deckOfCards[i]);
            }
            Console.ReadLine();
        }
    }
}
