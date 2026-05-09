using System;
using System.Collections.Generic;

namespace _0037_HA_Dynamic_array_advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SumCommand = "sum";
            const string ExitCommand = "exit";

            List<int> numbers = new List<int>();
            int sum = 0;
            bool isWork = true;

            while (isWork)
            {
                Console.Clear();

                Console.WriteLine($"Введите число.");
                Console.WriteLine($"{SumCommand} - вывести сумму.");
                Console.WriteLine($"{ExitCommand} - выход.\n");
                Console.WriteLine($"Сумма числа: {sum}");
                Console.WriteLine();
                OutputListNumbers(numbers);
                Console.WriteLine();

                string userInput = Console.ReadLine();

                if (userInput == ExitCommand)
                {
                    Console.WriteLine("Нажмите любую клавишу и программа закроется");
                    Console.ReadKey();
                    isWork = false;
                }

                if (userInput == SumCommand)
                {
                    sum = SumList(numbers);
                    Console.WriteLine($"Сумма чисел: {sum}");
                    Console.WriteLine("Для продолжения нажмите любую клвишу.");
                    Console.ReadKey();
                    continue;
                }

                if(int.TryParse(userInput, out int number) == true)
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Вы ввели неизвестную команду");
                    Console.WriteLine("Для продолжения нажмите любую клвишу.");
                    Console.ReadKey();
                }                
            }
        }

        private static int SumList(List<int> numbers)
        {
            int sum = 0;

            foreach (int i in numbers)
            {
                sum += i;
            }

            return sum;
        }

        private static void OutputListNumbers(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write($"{number}, ");
            }

            Console.WriteLine();
        }
    }
}
