namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Készítsünk programot, amely elkéri a felhasználó születési évét, ez alapján pedig kiszámítja és kiírja az
            életkorát.A program írja ki azt is, hány éves lesz a felhasználó a következő évben.*/

            Console.Write("Enter your year of birth: ");
            int yearOfBirth = int.Parse(Console.ReadLine());
            int currentYear = DateTime.Now.Year;
            int age = currentYear - yearOfBirth;
            Console.WriteLine($"You are now {age} years old.");
            Console.WriteLine($"You will be {age + 1} next year.");
            Console.ReadLine();
        }
    }
}
