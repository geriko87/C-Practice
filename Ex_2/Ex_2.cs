namespace Ex_2
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

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(10, 5);
            Console.CursorVisible = false;
            Console.WriteLine("Hello, World!");
            Console.ResetColor();
            Console.WindowHeight = 30;
            Console.WindowWidth = 100;
            Console.ReadKey();
        }
    }
}
