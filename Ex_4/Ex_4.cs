namespace Ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Készítsünk programot, amely elkéri a felhasználó születési évét, ez alapján pedig kiszámítja és kiírja az
            életkorát.A program írja ki azt is, hány éves lesz a felhasználó a következő évben.*/

            Console.Write("Add meg a születési éved: ");
            int yearOfBirth = int.Parse(Console.ReadLine());
            int yearNow = DateTime.Now.Year;
            int age = yearNow - yearOfBirth;

            Console.WriteLine($"Ebben az évben {age} éves vagy.");
            Console.WriteLine($"Jövőre {age + 1} éves leszel.");

            Console.ReadLine();
        }
    }
}
