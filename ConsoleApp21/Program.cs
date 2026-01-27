using System;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Készítsünk tízes számrendszerből kettes számrendszerbe átváltó alkalmazást.A bemenet legyen egy 32
            //bites előjel nélküli egész(uint), kimenetként pedig jelenítsük meg az érték kettes számrendszerbeli alakját 8
            //bites blokkokban, big endian formátumban.
            //Példa
            //420(10) = 00000000 00000000 00000001 10100100(2)

            Console.Write("Enter the number: ");
            uint number = uint.Parse(Console.ReadLine());
            uint numberInBase10 = number;
            string binary = "";

            while(number > 0) 
            {
                uint remainder = number % 2;
                binary = remainder + binary;
                number = number / 2;
            }

            Console.WriteLine($"{numberInBase10}(10) = {binary}(2)");
            Console.ReadLine();
        }
    }
}
