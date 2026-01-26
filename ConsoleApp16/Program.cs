namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Írjunk programot, amelynek kezdetén adott egy pozitív egész szám, a „gondolt szám”. A felhasználónak ki
            //kell találnia, hogy mi a gondolt szám.Ehhez a felhasználó megadhat számokat, melyekről a program megmondja,
            //hogy a gondolt számnál nagyobbak vagy kisebbek-e.A program akkor ér véget, ha a felhasználó kitalálta a gondolt
            //számot.A program jelenítse meg a felhasználó próbálkozásainak számát is.

            int thoughtNumber = 15;
            int attempts = 0;

            bool result = false;
            while (!result) 
            {
                Console.Write("Enter a number and I'll check if your guess was successful: ");
                int bet = int.Parse(Console.ReadLine());
                Console.Clear();

                attempts++;
                if (bet == thoughtNumber)
                {
                    Console.WriteLine($"Congratulations! It took {attempts} attempts.\nPress enter to exit!");
                    Console.ReadLine();
                    result = true;
                    break;
                }
                else 
                {
                    if (bet < thoughtNumber)
                    {
                        Console.WriteLine("Wrong guess! The entered number is smaller.\nTry again! Press a button to continue!");
                    }
                    else 
                    {
                        Console.WriteLine("Wrong guess! The entered number is bigger.\nTry again! Press a button to continue!");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }

        }
    }
}
