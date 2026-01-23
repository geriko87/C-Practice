namespace Ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kérjünk el a felhasználótól egy másodpercben megadott időtartamot, majd írjuk ki azt perc:másodperc
            formátumban.
            Példa
            Az időtartam másodpercben: 123
            Az időtartam formázva: 2:03*/

            Console.Write("Az időtartam másodpercben: ");
            int totalSeconds = int.Parse(Console.ReadLine());
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            Console.WriteLine($"Az időtartam formázva: {minutes}:{seconds:D2}");
            Console.ReadKey();
        }
    }
}
