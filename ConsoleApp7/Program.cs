namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kérjük el a felhasználótól a jelszavát, majd kérjük el még egyszer megerősítésképp.Ha egyezik a két
            megadott jelszó, nyugtázzuk egy zöld színnel kiírt üzenettel, ellenkező esetben jelenítsünk meg egy piros színű
            hibaüzenetet.*/

            Console.Write("Enter password: ");
            string password1 = Console.ReadLine();
            Console.Write("Enter the password again: ");
            string password2 = Console.ReadLine();

            if (password1 != password2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect password!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct password.");
            }
            Console.ReadLine();
        }
    }
}
