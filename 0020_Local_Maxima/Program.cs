using System;
using System.Reflection;
using System.Xml.Linq;

namespace _0020_Local_Maxima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int numberOfColumns = 30;
            int[] numbers = new int[numberOfColumns];

            int position = 10;

            string messageLocalMaxima = "\nВывод номера индекса и через дробь(/) его локального максимума: ";

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 9);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(messageLocalMaxima);
            Console.WriteLine();

            if (numbers[0] > numbers[1])
            {
                Console.WriteLine($"1/{numbers[0]}".PadLeft(position));
            }

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    Console.WriteLine($"{i + 1} / {numbers[i]}".PadLeft(position));
                }
            }

            int lastIndex = numbers.Length - 1;

            if (numbers[lastIndex] > numbers[lastIndex - 1])
            {
                Console.WriteLine($"{numbers.Length} / {numbers[lastIndex]}".PadLeft(position));
            }

            Console.ReadKey();
        }
    }
}
