using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Módosítsuk az előző feladat megoldását úgy, hogy a felhasználótól bekért szavakat egy listában tároljuk el,
            //és a bekérést a STOP kulcsszó megadásakor fejezzük be. Ha szükséges, módosítsuk a két előbbi lekérdezést is.
            //Milyen hasonlóságokat és különbségeket tapasztalunk a tömbök és listák használatában?

            //Kérjünk el a felhasználótól előre megadott darabszámú szót, amelyeket tároljunk el egy tömbben. Ezután
            //kérjünk el a felhasználótól egy további szót, és válaszoljuk meg az alábbiakat.
            //• Benne van-e a gyűjteményben a megadott szó ?
            //• Ha benne van, hol található először ?

            List<string> words = new List<string>();
            string input;
            do 
            {
                Console.Write($"Adj meg egy szót(Stop = befejezés): ");
                input = Console.ReadLine();
                words.Add(input);
            }
            while(input != "Stop");

            Console.Write($"Add meg a keresett szót: ");
            string searchedWord = Console.ReadLine();
            Console.Clear();

            bool found = false;
            int index = 0;

            foreach (string w in words)
            {
                index++;
                if (w == searchedWord)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine($"A keresett szó megtalálható a {index}. helyen.");
            }
            else
            {
                Console.WriteLine("A keresett szó nem található.");
            }
            Console.ReadLine();
        }
    }
}
