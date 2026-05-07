using System;
using System.Collections.Generic;

namespace _0037_HA_Dynamic_array_advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string AddCommand = "add";
            const string SumCommand = "sum";
            const string ExitCommand = "exit";

            List<int> numbers = new List<int>();
            int sum = 0;
            bool isWork = true;

            while (isWork)
            {
                Console.Clear();

                Console.WriteLine($"{AddCommand} - добавить число.");
                Console.WriteLine($"{SumCommand} - вывести сумму.");
                Console.WriteLine($"{ExitCommand} - выход.");

                OutputListNumbers(numbers);

                Console.WriteLine("Введите команду: \n");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case AddCommand:
                        AddNumber(numbers);
                        break;

                    case SumCommand:
                        sum = SumList(numbers);
                        Console.WriteLine($"Сумма чисел: {sum}");
                        Console.ReadKey();
                        break;

                    case ExitCommand:
                        Console.WriteLine("Нажмите любую клавишу и программа закроется");
                        Console.ReadKey();
                        isWork = false;
                        break;

                    default:
                        Console.WriteLine("Вы ввели неизвестную команду");
                        break;
                }
            }
        }

        private static void AddNumber(List<int> numbers)
        {
            string userInput;
            int number;
            do
            {
                Console.WriteLine("Введите число");
                userInput = Console.ReadLine();

            }
            while (int.TryParse(userInput, out number) == false);

            numbers.Add(number);
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
