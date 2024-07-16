using System;

namespace _0025_Shifting_array_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numberOfColumns = 10;

            int minNumberRandomness = -10;
            int maxNumberRandomness = 10;

            int[] numbers = new int[numberOfColumns];

            int shift = 1;

            for (int i = 0; i < numberOfColumns; i++)
            {
                numbers[i] = random.Next(minNumberRandomness, maxNumberRandomness);
                Console.Write($"{numbers[i]}, ");
            }

            for (int i = 0; i < shift; i++)
            {
                int temp = numbers[0];

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Length - 1] = temp;
            }

            Console.WriteLine($"\n\nМассив после сдвига на {shift} позиций влево:");

            for (int i = 0; i < numberOfColumns; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }

            Console.ReadKey();
        }
    }
}
