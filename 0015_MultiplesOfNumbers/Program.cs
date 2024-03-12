using System;

namespace _0015_MultiplesOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberN;
            int startInterval = 10;
            int endInterval = 25;

            int minRange = 50;
            int maxRange = 150;

            int counter = 0;

            Random random = new Random();
            numberN = random.Next(startInterval, endInterval + 1);

            for (int i = 0; i < maxRange; i += numberN)
            {
                if (i >= minRange)
                {
                    Console.WriteLine($"Кратное число {i}\n");
                    counter++;
                }
            }
            
            Console.WriteLine($"Количество чисел кратных {numberN} - {counter}");
            Console.ReadKey();
        }
    }
}
