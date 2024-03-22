using System;

namespace _0018_Rows_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numberOfRows = 5;
            int numberOfColumns = 5;

            int minNumberRandomness = 1;
            int maxNumberRandomness = 10;

            int sumRow = 0;
            int productColumn = 0;

            bool isFirstElement = true;

            int numberRowsForAmount = 2;
            int numberColumnsForProduct = 1;

            int[,] array = new int[numberOfRows, numberOfColumns];

            Console.WriteLine($"Создан массив");
            Console.WriteLine();

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    array[i, j] = random.Next(minNumberRandomness, maxNumberRandomness);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < numberOfColumns; i++)
            {
                sumRow += array[numberRowsForAmount - 1, i];
            }

            for(int i = 0;i < numberOfRows; i++)
            {
                if (isFirstElement)
                {
                    productColumn = array[i, numberColumnsForProduct - 1];
                    isFirstElement = false;
                }
                else
                {
                    productColumn *= array[i, numberColumnsForProduct - 1];
                }
            }

            Console.WriteLine($"Сумма второй строки  равна - {sumRow}") ;
            Console.WriteLine($"Произведение первого столбца - {productColumn}");
            Console.ReadKey();
        }
    }
}
