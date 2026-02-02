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

            string [] colours = { "Kör", "Káró", "Treff", "Pikk" };
            string[] types = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jumbó", "Dáma", "Király", "Ász" };

            for (int i = 0; i < colours.Length; ++i) 
            {
                for (int j = 0; j < types.Length; ++j) 
                {
                    Console.WriteLine($"{colours[i]} {types[j]}");
                }
            }
            Console.ReadLine();
        }
    }
}
