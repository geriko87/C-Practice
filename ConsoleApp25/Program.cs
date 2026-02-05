namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kérjünk el a felhasználótól előre megadott darabszámú szót, amelyeket tároljunk el egy tömbben. Ezután
            //kérjünk el a felhasználótól egy további szót, és válaszoljuk meg az alábbiakat.
            //• Benne van-e a gyűjteményben a megadott szó ?
            //• Ha benne van, hol található először ?

            string[] words = new string[5];

            for (int i = 0; i < words.Length; ++i)
            {
                Console.Write($"Add meg az {i + 1}. szót: ");
                string input = Console.ReadLine();
                Console.Clear();
                words[i] = input;
            }

            Console.Write($"Add meg a keresett szót: ");
            string searchedWord = Console.ReadLine();
            Console.Clear();

            bool found = false;
            int index = 0;
            foreach (string w in words) 
            {
                index++;
                if (w == searchedWord)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine($"A keresett szó megtalálható a {index}. helyen.");
            }
            else 
            {
                Console.WriteLine("A keresett szó nem található.");
            }
            Console.ReadLine();
        }
    }
}
