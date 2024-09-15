using System;

namespace _0029_Kansas_City_shuffle
{

    internal class Program
    {

        static void Main(string[] args)
        {
            int[] caunts = { 4, 6, 7, 8, 9, 1, 2, 3, 5 };
            PrintingAnArray(caunts);
            Shuffle(caunts);
            Console.WriteLine();
            PrintingAnArray(caunts);

            Console.ReadKey();
        }

        static void PrintingAnArray(int[] caunts)
        {
            for (int i = 0; i < caunts.Length; i++)
            {
                Console.Write($"{ caunts[i]} ");
            }
        }

        static void Shuffle(int[] caunts)
        {
            Random random = new Random();

            for (int i = 0; i < caunts.Length;  i++)
            {
                int j = random.Next(caunts.Length);
                int temp = caunts[i];
                caunts[i] = caunts[j];
                caunts[j] = temp;
            }
        }
    }
}
