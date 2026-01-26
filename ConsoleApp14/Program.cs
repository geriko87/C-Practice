namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Írjunk programot, amely addig generál véletlen számokat 1 és 1000 között, amíg az meg nem egyezik a
            //program kezdetén a felhasználó által megadott számmal.Számoljuk meg, hány próbálkozás kellett a találathoz.

            Console.Write("Enter a positive integer between 1 and 1000: ");
            int number = int.Parse(Console.ReadLine());
            int rndNumber;
            int attempts = 0;

            Random rnd = new Random();
            do
            {
                rndNumber = rnd.Next(1001);
                attempts++;

                Console.WriteLine(rndNumber);
            } while (rndNumber != number);

            Console.WriteLine($"It took {attempts} attempts.");
            Console.ReadLine();
        }
    }
}