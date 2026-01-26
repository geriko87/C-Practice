namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kérjünk el egy pozitív egész számot, majd írjuk ki a faktoriálisát.
            //N! = N × (N − 1) × (N − 2) × . . . × 3 × 2 × 1
            //Példa
            //N = 5
            //5! = 5×4×3×2×1 = 120

            Console.Write("Enter a number and I'll write out its factorial: ");
            int number = int.Parse(Console.ReadLine());

            int factorial = number;

            Console.Write($"{number}! = {number}");
            for (int i = number - 1; i > 0; --i) 
            {
                factorial *= i;
                Console.Write("*" + i);
            }
            Console.WriteLine(" = " + factorial);
            Console.ReadLine();
        }
    }
}
