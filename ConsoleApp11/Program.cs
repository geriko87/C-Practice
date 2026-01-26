namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Adott egy V térfogatú tartály, amit két csővezetéken keresztül töltünk fel fel.Ismerjük a vezetékekben a
            térfogatáramot(az egy óra alatt átfolyó térfogatot).A két vezetéket egyszerre nyitjuk meg, majd T óráig folyni
            hagyjuk.Adjuk meg, hogy az időtartam végén mennyire telt meg a tartály.
            Példa
            V = 1000
            R1 = 100
            R2 = 120
            T = 3
            -- > A tartály 66 % -ban lesz tele.
            Példa
            V = 100
            R1 = 100
            R2 = 100
            T = 2.5
            -- > A tartály 400 m3 - rel lesz túltöltve.*/

            double V1 = 1000;
            double R1 = 100;
            double R2 = 120;
            double T1 = 3;

            double tankSaturation = ((R1 + R2) * T1) / V1;
            Console.WriteLine($"The tank will be {tankSaturation * 100}% full.");

            double V2 = 100;
            double R3 = 100;
            double R4 = 100;
            double T2 = 2.5;

            double overfilledTank = ((R3 + R4) * T2) - V2;
            Console.WriteLine($"The tank will be overfilled by {overfilledTank} m3.");

            Console.ReadLine();
        }
    }
}
