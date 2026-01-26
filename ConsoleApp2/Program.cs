namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bővítsük ki az előbbi programot: helyezzünk el néhányat az alábbi utasításokból a szöveg megjelenítését
            végző utasítás elé vagy után. Az utasítások a kurzor és a parancssori ablak jellemzőit módosítják.
            • Console.Clear()
            • Console.WindowHeight
            • Console.WindowWidth
            • Console.BackgroundColor
            • Console.ForegroundColor
            • Console.SetCursorPosition()
            • Console.CursorVisible*/

            Console.WindowHeight = 20;
            Console.WindowWidth = 100;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(5, 10);
            Console.CursorVisible = false;

            Console.WriteLine("Hello World!");
            Console.ResetColor();
            Console.WriteLine("Hello World!");
            Console.Clear();
            Console.ReadLine();

        }
    }
}
