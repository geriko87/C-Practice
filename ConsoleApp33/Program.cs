namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Írjunk programot, amely meghatározza, hogy egy szöveg palindrom szöveg - e, vagyis hogy előre olvasva
            //ugyanazt adja-e, mint visszafelé.
            //Példa
            //A „Géza kék az ég.”, az „Indul a görög aludni.” vagy a „Rád rohan a hordár.” szövegek palindrom szövegek.

            Console.Write("Add meg a szöveget: ");
            string input = Console.ReadLine();

            string cleanedInput = "";

            foreach(char c in input)
            {
                if (char.IsLetterOrDigit(c)) 
                {
                    cleanedInput += char.ToLower(c);
                }
            }

            string reversedInput = "";
            for (int i = cleanedInput.Length - 1; i >= 0; --i) 
            {
                reversedInput += cleanedInput[i];
            }
            Console.WriteLine();

            if (reversedInput == cleanedInput)
            {
                Console.WriteLine($"A megadott szöveg palindrom szöveg.");
            }
            else 
            {
                Console.WriteLine($"A megadott szöveg nem palindrom szöveg.");
            }

            Console.ReadLine();
        }
    }
}
