using System;

namespace _0019_Largest_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numberOfRows = 10;
            int numberOfColumns = 10;

            int minNumberRandomness = 1;
            int maxNumberRandomness = 100;

            int numberToReplace = 0;

            int[,] array = new int[numberOfRows, numberOfColumns];

            int maxElement = int.MinValue;

            Console.WriteLine($"Создан массив");
            Console.WriteLine();

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    array[i, j] = random.Next(minNumberRandomness, maxNumberRandomness);
                    Console.Write(array[i, j] + "  ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    if (array[i, j] > maxElement)
                    {
                        maxElement = array[i, j];
                    }                   
                }               
            }

            Console.WriteLine();

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    if (array[i, j] == maxElement)
                    {
                         array[i, j] = numberToReplace;
                    }                    
                }               
            }

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {                   
                    Console.Write(array[i, j] + "  ");                  
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine($"Наибольший элемент - {maxElement}");
            Console.ReadKey();
        }
    }
}
