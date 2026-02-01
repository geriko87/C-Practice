namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Készítsünk egyszerű félkarú rabló játékot.A játék elején a játékos 100 kredittel rendelkezik, a tét alapesetben
            //1 kredit.A Spacebar billentyű lenyomásakor a játék három véletlen számjegyet pörget. Két egyforma szám esetén
            //a tét 10 - szeresét, három egyforma esetén a tét 50 - szeresét nyeri a felhasználó.Pörgetés előtt a tétet a Fel és Le
            //kurzorbillentyűkkel lehet módosítani.A játék véget ér Escape nyomáskor, vagy ha a játékosnak elfogy a kreditje.
            int credit = 99;
            int bet = 1;

            while (credit >= 0) 
            {
                Random rnd = new Random();

                Console.WriteLine($"Credit: {credit}\nBet: {bet}\n\nYou can increase or decrease your bet using the Up/Down buttons." +
                    $"\nPress Space to start or Escape to exit.");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.UpArrow && credit > 0)
                {
                    credit -= 1;
                    bet += 1;

                }
                else if (keyInfo.Key == ConsoleKey.DownArrow && bet > 0)
                {
                    credit += 1;
                    bet -= 1;
                }
                else if (keyInfo.Key == ConsoleKey.Escape) 
                {
                    Console.WriteLine($"\nThe prize {credit + bet} credit!\nPress a button to exit..");
                    Console.ReadKey();
                    break;
                }

                if (keyInfo.Key == ConsoleKey.Spacebar && bet != 0) 
                {
                    int first = rnd.Next(10);
                    int second = rnd.Next(10);
                    int third = rnd.Next(10);
                    Console.WriteLine($"\n{first} {second} {third}");
                    if (first == second && second == third)
                    {
                        credit += bet * 50;
                        Console.WriteLine($"Congratulations! You won {bet * 50} credit!");
                    }
                    else if (first == second || second == third || first == third)
                    {

                        credit += bet * 10;
                        Console.WriteLine($"Congratulations! You won {bet * 10} credit!");
                    }
                    else
                    {
                        credit -= bet;
                    }
                    Console.WriteLine("\nPress a button to continue..");
                    Console.ReadKey();
                }
                Console.Clear();
            }
            if(credit < 0)
            {
                Console.WriteLine("You have no more credits. The game is over." +
                    "\nPress a button to exit..");
                Console.ReadKey();
            }
        }
    }
}
