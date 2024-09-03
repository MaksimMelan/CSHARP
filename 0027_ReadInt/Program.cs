using System;

namespace _0027_ReadInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = ReadNumberFromConsole();
            Console.WriteLine($"Вы ввели: {number}");

            Console.ReadKey();
        }

        static int ReadNumberFromConsole()
        {
            int number;
            string input;
            bool success = false;

            do
            {
                Console.Write("Введите число:");
                input = Console.ReadLine();

                success = int.TryParse(input, out number);
            }while(!success);

            return number;
        }
    }
}
