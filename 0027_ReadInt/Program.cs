using System;

namespace _0027_ReadInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = ReadNumber();
            Console.WriteLine($"Вы ввели: {number}");

            Console.ReadKey();
        }

        static int ReadNumber()
        {
            int number;
            string input;           

            do
            {
                Console.Write("Введите число:");
                input = Console.ReadLine();
            
            }while(int.TryParse(input, out number) == false);

            return number;
        }
    }
}
