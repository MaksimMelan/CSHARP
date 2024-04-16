using System;

namespace _0020_Local_Maxima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numberOfColumns = 15;

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

                Console.WriteLine($"№{i +1 } {array[i]}  ");
            }

            Console.Write($"\n{messageLocalMaxima}\n\n");

            if (array[0] > array[1])
            {
                indexNumber = 0;
                localMaxima = array[0];
                Console.WriteLine($"{indexNumber + 1}/{localMaxima}".PadLeft(indentationForDataOutput));
            }

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    indexNumber = i;
                    localMaxima = array[i];

                    Console.WriteLine($"{indexNumber + 1}/{localMaxima}".PadLeft(indentationForDataOutput));
                }
            }

            if(array[array.Length - 1] > array[array.Length -2])
            {
                indexNumber = array.Length;
                localMaxima = array[array.Length - 1];
                Console.WriteLine($"{indexNumber}/{localMaxima}".PadLeft(indentationForDataOutput));
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
