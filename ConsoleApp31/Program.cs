namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Töltsünk fel egy egydimenziós tömböt megadott számú véletlen értékkel, majd valósítsuk meg az alábbi
            //műveleteket, majd oldjuk meg a feladatot listával is.
            //• Válogassuk ki a gyűjtemény minden második elemét egy új gyűjteménybe.
            //• Fordítsuk meg a gyűjtemény elemeinek sorrendjét.
            //• Rendezzük a lehető legkisebb négyzetes mátrixba a gyűjtemény elemeit(az esetlegesen üresen maradó
            //értékek helyére nulla kerüljön).

            Random rnd = new Random();

            int[] array = new int[rnd.Next(1, 50) * 2];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(8);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int[] newArray = new int[array.Length / 2];
            int counter = 0;
            for (int i = 0; i < array.Length; i+=2)
            {
                newArray[counter] = array[i];
                Console.Write(newArray[counter] + " ");
                counter++;
            }
            Console.WriteLine();

            for (int i = 0; i < newArray.Length / 2; ++i) 
            {
                int temp = newArray[i];
                newArray[i] = newArray[newArray.Length - i - 1];
                newArray[newArray.Length - i - 1] = temp;
            }
            for (int i = 0; i < newArray.Length; ++i) 
            {
                Console.Write(newArray[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(newArray.Length);
            double sqrtNewArray = Math.Sqrt(newArray.Length);
            Console.WriteLine(sqrtNewArray);

            int roundedSize = (int)Math.Ceiling(sqrtNewArray);
            Console.WriteLine(roundedSize);

            int index = 0;
            int[,] newArrayMatrix = new int[roundedSize, roundedSize];
            Console.WriteLine();

            for (int i = 0; i < roundedSize; ++i) 
            {
                for (int j = 0; j < roundedSize; ++j) 
                {
                    if (index < newArray.Length)
                    {
                        newArrayMatrix[i, j] = newArray[index];
                        index++;
                    }
                    else
                    {
                        newArrayMatrix[i, j] = 0;
                    }
                    Console.Write(newArrayMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
