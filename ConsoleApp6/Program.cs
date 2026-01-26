namespace ConsoleApp6
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

            Console.Write("Enter a duration in seconds: ");
            int totalSeconds = int.Parse(Console.ReadLine());
            int inMinutes = totalSeconds / 60;
            int inSeconds = totalSeconds % 60;
            Console.WriteLine($"The duration in seconds: {totalSeconds}");
            Console.WriteLine($"The duration in formatted: {inMinutes:D2}:{inSeconds:D2}");
            Console.ReadKey();
        }
    }
}
