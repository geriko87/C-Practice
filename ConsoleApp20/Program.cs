namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Készítsünk időzítő alkalmazást, amely elkér egy másodpercben megadott időtartamot, majd kiírja azt a
            //képernyőre perc: másodperc formátumban, és visszaszámlálást indít. Minden eltelt másodperc után törölje a
            //képernyőt, és írja ki a még hátralévő időt.A visszaszámlálást végét jelezze a képernyő pirosra váltásával és
            //sípolással.
            //A késleltetéshez használjuk a System.Threading.Thread.Sleep(1000); utasítást.

            Console.Write("Enter the duration in seconds: ");
            int totalInSeconds = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = totalInSeconds; i > 0; --i) 
            {
                int inMinutes = i / 60;
                int inSeconds = i % 60;

                if (i <= 10)
                {   
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep();
                }

                Console.WriteLine($"{inMinutes:D2}:{inSeconds:D2}");
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.Beep(1000, 1000);
            Console.ReadLine();
        }
    }
}
