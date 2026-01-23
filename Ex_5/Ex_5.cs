namespace Ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Készítsünk programot, amely elkéri a felhasználó testmagasságát(h, méterben) és testtömegét(m, kilo-
            grammban), majd kiszámítja és kiírja a felhasználó testtömegindexét(BM I).A számításhoz használt formula:BMI = m/(h*h)*/

            Console.Write("Enter your height in meters: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Enter your weight in kilograms: ");
            double weight = double.Parse(Console.ReadLine());

            double BMI = weight / (height * height);
            Console.WriteLine($"Your body mass index is {BMI:F2}.");
            Console.ReadLine();
        }
    }
}
