namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Írjunk programot, amely sztenderd formátumra hozza egy jármű rendszámát. A jelenlegi sztenderd formátum
            //kétszer két nagybetű, közöttük egy szóköz, majd egy kötőjel és három szám.
            //Példa
            //A következő rendszámok mindegyike sztenderd formátumban AA BC - 123:
            //• aabc 123
            //• a a BC123
            //• a a B c 1 2 3
            //• AABc - 123

            string input = Console.ReadLine();
            string cleanedInput = "";

            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c))
                {
                    cleanedInput += char.ToUpper(c);
                }
            }

            if (cleanedInput.Length == 7 && char.IsLetter(cleanedInput[0]) && char.IsLetter(cleanedInput[1]) && char.IsLetter(cleanedInput[2])
                && char.IsLetter(cleanedInput[3]) && char.IsDigit(cleanedInput[4]) && char.IsDigit(cleanedInput[5]) 
                && char.IsDigit(cleanedInput[6])) 
            {
                Console.WriteLine($"{cleanedInput[0]}{cleanedInput[1]} {cleanedInput[2]}{cleanedInput[3]} - " +
                    $"{cleanedInput[4]}{cleanedInput[5]}{cleanedInput[6]}");
            }
            else 
            {
                Console.WriteLine("Hibás a rendszám formátuma!");
            }
            Console.ReadLine();
        }
    }
}
