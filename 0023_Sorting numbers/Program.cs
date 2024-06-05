using System;

namespace _0023_Sorting_numbers
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

            for (int i = 0; i < numberOfColumns ; i++)
            {
                numbers[i] = random.Next(minNumberRandomness, maxNumberRandomness);
                Console.Write($"{ numbers[i]}, ");
            }

            for(int i = 0; i < numberOfColumns; i++)
            {
                for(int j = 0; j < numberOfColumns - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\n\nЧисла массива отсортированы, от меньшего до большего:\n " + string.Join(", ", numbers));
            Console.ReadKey();
        }
    }
}
