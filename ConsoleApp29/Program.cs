using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Egy horgászverseny fogási adatait egy F táblázatban(kétdimenziós tömbben) tároljuk.F(i, j) azt jelenti,
            //hogy az i-edik horgász a j - edik halfajtából hány darabot fogott.
            //• Generáljuk le véletlenszerűen a táblázat adatait.
            //• Jelenítsük meg formázottan a fogási adatokat a képernyőn.
            //• Adjuk meg, hogy a horgászok mennyit fogtak az egyes halfajtákból.
            //• Melyik horgász fogta a legtöbb halat összesen ?
            //• Volt - e olyan horgász, aki egyetlen halat sem fogott?

            Random rnd = new Random();

            string[] anglers = new string[] { "Geri", "Laci", "Dani", "Robi", "Géza", "Feri" };
            string[] fish = new string[] { "Ponty", "Csuka", "Harcsa", "Sügér", "Keszeg" };

            List<string>[] catches = new List<string>[anglers.Length];

            for (int i = 0; i < anglers.Length; ++i) 
            {
                catches[i] = new List<string>();

                for (int j = 0; j < rnd.Next(25); ++j)
                {
                    catches[i].Add(fish[rnd.Next(fish.Length)]);
                }
            }

            for (int i = 0; i < anglers.Length; ++i)
            {
                Console.Write($"{anglers[i]}: ");

                for (int j = 0; j < catches[i].Count; ++j) 
                {
                    if (j > 0)
                        Console.Write(", ");
                    Console.Write(catches[i][j]);
                }
                Console.WriteLine();
            }

            int[] fishTypes = new int[fish.Length];
            int counter = -1;

            for (int i = 0; i < fish.Length; ++i) 
            {
                for (int j = 0; j < catches.Length; ++j) 
                {
                    for (int k = 0; k < catches[j].Count; ++k)
                    {
                        if (catches[j][k] == fish[i])
                            fishTypes[i]++;
                    }
                }
            }
            Console.WriteLine($"\nA horgászok által kifogott halak: ");
            foreach (string f in fish)
            {
                counter++;
                Console.WriteLine($"{f} {fishTypes[counter]}db.");
            }

            int biggestCatches = catches[0].Count;
            string bestAngler = anglers[0];
            for (int i = 1; i < catches.Length; ++i)
            {
                if (biggestCatches < catches[i].Count)
                {
                    biggestCatches = catches[i].Count;
                    bestAngler = anglers[i];
                }
            }
            Console.WriteLine($"\nA legtöbb { biggestCatches } db halat {bestAngler} fogta.");

            for(int i = 0; i < catches.Length; ++i)
            {
                if (catches[i].Count == 0)
                    Console.WriteLine($"\n{anglers[i]} nem fogott egy halat sem.");
            }
            Console.ReadLine();
        }
    }
}
