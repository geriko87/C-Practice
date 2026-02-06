using System.CodeDom.Compiler;
using System.Security.Cryptography;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Felmérést végzünk barátaink programozói ismereteiről.Kérjük el az adott személy nevét(string), életkorát
            //(int) és hogy rendelkezik - e programozói tapasztalattal(bool). A neveket, életkorokat és tapasztalatokat tároljuk
            //három külön listában, amelyeket az kapcsol össze, hogy egy adott indexen egy konkrét személy adatait találjuk.
            //A bekérést egy üres név megadásáig folytassuk.Ezt követően határozzuk meg az alábbiakat.
            //• Mi az átlagéletkor a teljes adathalmazban? (Használjuk a foreach utasítást a bejáráshoz.)
            //• Mi az átlagéletkor a programozói tapasztalat nélküli személyek között?
            //• Hány éves a legidősebb, programozó tapasztalattal rendelkező személy és mi a neve?

            List<string> names = new List<string>();
            List<int> ages = new List<int>();
            List<bool> experience = new List<bool>();

            while (true)
            {
                Console.Clear();
                Console.Write("Név megadása(a befejezéshez hagyd üresen): ");
                string name = Console.ReadLine();
                if (name != "")
                {
                    names.Add(name);
                }
                else
                {
                    Console.Clear();
                    break;
                }

                Console.Write("Kor: ");
                int age = int.Parse(Console.ReadLine());
                ages.Add(age);

                Console.Write("Tapasztalat(igen/nem): ");
                string exp = Console.ReadLine();
                if (exp == "igen")
                    experience.Add(true);
                else if(exp == "nem")
                    experience.Add(false);
            }

            int totalAges = 0;
            foreach (int a in ages)
            {
                totalAges += a;
            }
            if (ages.Count > 0)
                Console.WriteLine($"Az átlag életkor a teljes adathalmazban: {totalAges / ages.Count}");
            else
            {
                Console.Clear();
                Console.WriteLine("Üres az adathalmaz.");
            }

            int allAgesNoExp = 0;
            int personNoExp = 0;
            for (int i = 0; i < experience.Count; ++i)
            {
                if (experience[i] == false)
                {
                    allAgesNoExp += ages[i];
                    personNoExp++;
                }
            }
            int averageAge = 0;
            if (personNoExp != 0)
            {
                averageAge = allAgesNoExp / personNoExp;
                Console.WriteLine($"Az átlag életkor a tapasztalat nélküli személyek között: {averageAge}");
            }

            int oldestHasExpAge = 0;
            string oldestHasExpName = "";
            for (int i = 0; i < ages.Count; ++i)
            {
                if (experience[i] == true)
                {
                    if (oldestHasExpAge < ages[i])
                    {
                        oldestHasExpAge = ages[i];
                        oldestHasExpName = names[i];
                    }
                }
            }
            if (oldestHasExpAge > 0)
                Console.WriteLine($"A legidősebb programozói tapasztalattal rendelkező személy: {oldestHasExpName}, {oldestHasExpAge}");
            Console.ReadLine();
        }
    }
}
