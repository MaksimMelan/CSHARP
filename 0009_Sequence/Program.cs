using System;

namespace _0009_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minCount = 5;
            int maxCount = 103;
            int progressionDifference = 7;

            for (int i = minCount; i <= maxCount; i += progressionDifference)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
