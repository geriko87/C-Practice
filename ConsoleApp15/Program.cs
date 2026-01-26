namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Társasjátékoknál gyakori, hogy az kezd, aki először hatos dob.Készítsünk egy alkalmazást, amely eldönti,
            //hogy N játékos közül ki kezdjen.Minden játékosnál az Enter leütésére dobjunk egy véletlen számot 1 és 6 között,
            //majd ha az nem hatos, ugorjunk a következő játékosra. Ha körbeértünk, a folyamat induljon újra, egészen addig,
            //amíg valaki hatost nem dob.

            Random rnd = new Random();

            Console.Write("Enter the number of players: ");
            int playersNumber = int.Parse(Console.ReadLine());
            Console.Clear();

            bool result = false;
            while (!result) 
            {
                for (int i = 1; i <= playersNumber; ++i) 
                {
                    Console.WriteLine($"Player {i}. press Enter to roll!");
                    Console.ReadLine();

                    int roll = rnd.Next(1, 7);
                    if (roll == 6)
                    {
                        Console.WriteLine($"Dice roll: {roll}");
                        Console.WriteLine($"Congratulations Player {i}.\n\nPress Enter to start game!");
                        Console.ReadKey();
                        result = true;
                        break;
                    }
                    else 
                    {
                        Console.WriteLine($"Dice roll: {roll}");
                        Console.WriteLine("Failed roll! Press a button to continue!");
                        Console.ReadKey();
                        Console.Clear();

                        if (i == playersNumber) 
                        {
                            i = 0;
                        }
                        continue;
                    }
                }
            }
        }
    }
}
