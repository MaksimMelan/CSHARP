using System;

namespace _0022_Under_an_array_of_repetitions_of_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numberOfColumns = 30;

            int minNumberRandomness = 1;
            int maxNumberRandomness = 10;

            int[] numbers = new int[numberOfColumns];

            for (int i = 0; i < numberOfColumns; i++)
            {
                numbers[i] = random.Next(minNumberRandomness, maxNumberRandomness);
            }

            int currentNum = numbers[0];
            int currentRepeating = 1;
            int maxRepeateCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentRepeating++;

                }
                else
                {
                    currentRepeating = 1;
                }

                if (currentRepeating > maxRepeateCount)
                {
                    maxRepeateCount = currentRepeating;
                    currentNum = numbers[i];
                }
            }

            Console.WriteLine("Массив: " + string.Join(", ", numbers));
            Console.WriteLine("Число: " + currentNum);
            Console.WriteLine("Количество повторений: " + maxRepeateCount);
            Console.ReadKey();
        }
    }
}
