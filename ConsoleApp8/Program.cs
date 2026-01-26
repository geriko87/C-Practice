namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kérjünk el a felhasználótól kettő számot és egy műveleti jelet, majd írjuk ki a képernyőre az adott művelet
            eredményét a két szám között elvégezve.
            Példa
            Add meg az első számot: 3
            Add meg a második számot: 7
            Add meg a műveletet: *
            3 * 7 = 21*/

            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the operation sign(+, -, *, /): ");
            char operationSing = char.Parse(Console.ReadLine());

            int summation = firstNumber + secondNumber;
            int subtraction = firstNumber - secondNumber;
            int multiplication = firstNumber * secondNumber;
            int division = firstNumber / secondNumber;

            if (operationSing == '+')
            {
                Console.WriteLine($"{firstNumber} {operationSing} {secondNumber} = {summation}");
            }
            else if (operationSing == '-')
            {
                Console.WriteLine($"{firstNumber} {operationSing} {secondNumber} = {subtraction}");
            }
            else if (operationSing == '*')
            {
                Console.WriteLine($"{firstNumber} {operationSing} {secondNumber} = {multiplication}");
            }
            else
            {
                Console.WriteLine($"{firstNumber} {operationSing} {secondNumber} = {division}");
            }
            Console.ReadLine();
        }
    }
}
