namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kérjünk el a felhasználótól egy N pozitív egész számot, majd írjuk ki az alábbiakat:
            //• N páros vagy páratlan
            //• N valódi pozitív osztóinak száma(1 - et és N - et nem kell beleszámolnunk)
            //• N prímszám vagy összetett szám

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Clear();

            if (number % 2 == 0)
            {
                Console.WriteLine($"The {number} is even.");
            }
            else 
            {
                Console.WriteLine($"The {number} is odd.");
            }

            int counter = 0;
            for (int i = 2; i < number / 2; ++i) 
            {
                if (number % i == 0)
                {
                    counter++;
                    Console.WriteLine($"\n{i} is divisor of {number}.");
                }
            }
            Console.WriteLine($"\nThe real divisors of {number} are {counter}.");

            if (counter == 0)
            {
                Console.WriteLine($"The {number} is a prime number.");
            }
            else 
            {
                Console.WriteLine($"The {number} is a composite number.");
            }

            Console.ReadLine();
        }
    }
}
