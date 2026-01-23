namespace Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Készítsünk programot, amely elkéri a felhasználó nevét, majd név szerint köszönti őt.

            Console.Write("Kérem, adja meg a nevét: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Üdvözöllek, {nev}!");
            Console.ReadKey();
        }
    }
}
