namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kérjünk egy a felhasználótól egy 0 és 9 közötti értéket, majd írjuk ki a számot szövegesen.Ha a tartományon
            kívüli értéket ad meg, tájékoztassuk hibaüzenettel.
            Példa
            Adj meg egy számot: 9
            Az általad megadott szám: kilenc*/

            Console.Write("Enter an integer between 0 and 9: ");
            char number = char.Parse(Console.ReadLine());

            if (number == '0')
            {
                Console.WriteLine("The given number is zero.");
            }
            else if (number == '1')
            {
                Console.WriteLine("The given number is one.");
            }
            else if (number == '2')
            {
                Console.WriteLine("The given number is two.");
            }
            else if (number == '3')
            {
                Console.WriteLine("The given number is three.");
            }
            else if (number == '4')
            {
                Console.WriteLine("The given number is four.");
            }
            else if (number == '5')
            {
                Console.WriteLine("The given number is five.");
            }
            else if (number == '6')
            {
                Console.WriteLine("The given number is six.");
            }
            else if (number == '7')
            {
                Console.WriteLine("The given number is seven.");
            }
            else if (number == '8')
            {
                Console.WriteLine("The given number is eight.");
            }
            else if (number == '9')
            {
                Console.WriteLine("The given number is nine.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error! You entered a value out of range!");
            }
            Console.ReadLine();
        }
    }
}
