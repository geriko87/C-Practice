namespace Ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Készítsünk programot, amely elkéri a felhasználó testmagasságát(h, méterben) és testtömegét(m, kilo-
            grammban), majd kiszámítja és kiírja a felhasználó testtömegindexét(BM I).A számításhoz használt formula:BMI = m/(h*h)*/

            Console.Write("Kérem adja meg a testmagasságát méterben: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem adja meg a testtömegét kilogrammban: ");
            double m = Convert.ToDouble(Console.ReadLine());
            double BMI = m / (h * h);
            Console.WriteLine($"Az Ön testtömegindexe: {BMI:F2}");
            Console.ReadKey();
        }
    }
}
