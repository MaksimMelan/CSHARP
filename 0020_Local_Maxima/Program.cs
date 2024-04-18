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

            int[] arrayNumbers = new int[numberOfColumns];

            int indentationForDataOutput = 10;

            int localMaxima = 0;

            string messageLocalMaxima = "\nВывод номера индекса и черз дробь(/) его локального максимума: ";

            Console.SetCursorPosition(indentationForDataOutput, Console.CursorTop);
            Console.WriteLine($"Создан массив\n");

            for (int i = 0; i < numberOfColumns; i++)
            {
                arrayNumbers[i] = random.Next(minNumberRandomness, maxNumberRandomness);

                Console.WriteLine($"№{i +1 } {arrayNumbers[i]}  ");
            }

            Console.Write($"\n{messageLocalMaxima}\n\n");

            if (arrayNumbers[0] > arrayNumbers[1])
            {
                Console.WriteLine($"1/{arrayNumbers[0]}".PadLeft(indentationForDataOutput));
            }

            for (int i = 1; i < arrayNumbers.Length - 1; i++)
            {
                if (arrayNumbers[i] > arrayNumbers[i - 1] && arrayNumbers[i] > arrayNumbers[i + 1])
                {
                    Console.WriteLine($"{i + 1}/{arrayNumbers[i]}".PadLeft(indentationForDataOutput));
                }
            }

            int indexOfLastElement = arrayNumbers.Length - 1;

            if (arrayNumbers[arrayNumbers.Length - 1] > arrayNumbers[indexOfLastElement - 1])
            {
                indexOfLastElement = arrayNumbers[arrayNumbers.Length - 1];
                Console.WriteLine($"{arrayNumbers.Length}/{arrayNumbers[arrayNumbers.Length - 1]}".PadLeft(indentationForDataOutput));
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
