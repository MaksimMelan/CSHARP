using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0023_Sorting_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numberOfColumns = 10;

            int minNumberRandomness = 1;
            int maxNumberRandomness = 10;

            int[] numbers = new int[numberOfColumns];

            for (int i = 0; i < numberOfColumns ; i++)
            {
                numbers[i] = random.Next(minNumberRandomness, maxNumberRandomness);
                Console.WriteLine($"{i + 1}-{ numbers[i]}");
            }

            for(int i = 0; i < numberOfColumns; i++)
            {
                for(int j = 0; j < numberOfColumns - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j = 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Массив: " + string.Join(", ", numbers));
            Console.ReadKey();


        }
    }
}
