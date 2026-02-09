namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kérjünk el a felhasználótól egy N pozitív egész értéket, és adjuk hozzá egy listához első elemként.Vegyük
            //a lista utoljára hozzáadott elemét, legyen ez K. Ha K páros, adjuk hozzá a listához K felét, ha páratlan, akkor
            //3K + 1 - et.Addig ismételjük az előbbieket, amíg 1 - et nem kapunk eredményül.
            //Kövessük nyomon a kiszámított érték és a lista állapotának változását hibakereső(debug) módban.Próbáljuk
            //meg hibakeresés közben módosítani az aktuálisan kiszámított értéket.

            List<int> numbers = new List<int>();

            Console.Write("Adj meg egy pozitív egész számot: ");
            int n = int.Parse(Console.ReadLine());
            numbers.Add(n);

            int k = -1;
            while (k != 1)
            {
                k = numbers[numbers.Count - 1];

                if (k % 2 == 0)
                {
                    numbers.Add(k / 2);
                }
                else
                {
                    numbers.Add((3 * k) + 1);
                }
                Console.WriteLine(k);
            }
            Console.ReadLine();
        }
    }
}
