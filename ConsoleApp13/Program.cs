namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tároljuk egy változóban a felhasználó jelszavát. Addig kérjük el tőle a jelszót a parancssorról, amíg az nem
            //egyezik az eltárolttal.Módosítsuk úgy a programot, hogy a felhasználó három sikertelen próbálkozás után kapjon
            //hibaüzenetet.

            string password1 = "1234";
            string password2;
            int count = 0;

            do
            {
                Console.Write("Enter the password: ");
                password2 = Console.ReadLine();
                count++;

            } while (password1 != password2 && count < 3);

            if (count < 3)
            {
                Console.WriteLine("Successful login!");
            }
            else
            {
                Console.WriteLine("Acces denied! No more attempts!");
            }

            Console.ReadLine();
        }
    }
}
