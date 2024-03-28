using System;

namespace _0020_Local_Maxima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numberOfColumns = 20;

            int minNumberRandomness = -100;
            int maxNumberRandomness = 100;

            int[] array = new int[numberOfColumns];

            int indentationForDataOutput = 10;
            int indexNumber = 0;
            int localMaxima = 0;

            string messageLocalMaxima = "\nВывод номера индекса и черз дробь(/) его локального максимума: ";

            Console.SetCursorPosition(indentationForDataOutput, Console.CursorTop);
            Console.WriteLine($"Создан массив\n");

            for (int i = 0; i < numberOfColumns; i++)
            {
                array[i] = random.Next(minNumberRandomness, maxNumberRandomness);
                Console.Write(array[i] + "  ");
            }

            Console.Write($"\n{messageLocalMaxima}\n\n");

            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((i == 0 || array[i] > array[i - 1]) && (i == array.Length - 1 || array[i] > array[i + 1]))
                {
                    indexNumber = i - 1;
                    localMaxima = array[i];
                    Console.WriteLine($"{indexNumber}/{localMaxima}".PadLeft(indentationForDataOutput));
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
