using System;

namespace _0003_Pictures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countImages = 52;
            int countRows = 3;
            int countString;
            float countSurplus;

            countString = countImages / countRows;
            countSurplus = Convert.ToSingle(countImages) % countRows;

            Console.WriteLine($"Полностью заполненных раядов {countString}. Лишних картин {countSurplus}");

            Console.ReadKey();
        }
    }
}
