namespace Ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Készítsünk programot, amely elkéri a felhasználó születési évét, ez alapján pedig kiszámítja és kiírja az
            életkorát.A program írja ki azt is, hány éves lesz a felhasználó a következő évben.*/

            Console.Write("Kérem adja meg a születési évét: ");
            int szuletesiEv = Convert.ToInt32(Console.ReadLine());
            int jelenlegiEv = DateTime.Now.Year;
            int eletkor = jelenlegiEv - szuletesiEv;
            Console.WriteLine($"Az Ön életkora: {eletkor} év.");
            Console.WriteLine($"A következő évben {eletkor + 1} éves lesz.");
            Console.ReadLine();
        }
    }
}
