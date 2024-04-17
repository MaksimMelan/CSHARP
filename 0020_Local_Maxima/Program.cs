using System;
using System.Reflection;
using System.Xml.Linq;

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

            int indexOfFirstElement;

            if (array[0] > array[1])
            {
                indexOfFirstElement = array[0];
                Console.WriteLine($"1/{indexOfFirstElement}".PadLeft(indentationForDataOutput));
            }

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    localMaxima = array[i];

                    Console.WriteLine($"{i + 1}/{localMaxima}".PadLeft(indentationForDataOutput));
                }
            }

            int indexOfLastElement;

            if (array[array.Length - 1] > array[array.Length -2])
            {
                indexOfLastElement = array[array.Length - 1];
                Console.WriteLine($"{array.Length}/{indexOfLastElement}".PadLeft(indentationForDataOutput));
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
