namespace Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Készítsünk programot, amely elkéri a felhasználó nevét, majd név szerint köszönti őt.

            Console.Write("Add meg a neved: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
            Console.ReadLine();
        }
    }
}
