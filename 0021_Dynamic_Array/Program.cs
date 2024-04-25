using System;

namespace _0021_Dynamic_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[0];
            int sum = 0;

            string sumCommand = "sum";
            string input = "";
            string exitCommand = "exit";
            bool isWorking = true;

            while (isWorking)
            {
                Console.Clear();

                Console.WriteLine($"Введите число, {sumCommand} или {exitCommand}: ");

                for (int j = 0; j < arrayNumbers.Length; j++)
                {
                    Console.Write(arrayNumbers[j] + " ");
                }

                Console.WriteLine($"\n");
                input = Console.ReadLine();

                if (input == sumCommand)
                {
                    Console.WriteLine($"\nСумма всех введённых чисел: ");

                    for (int j = 0; j < arrayNumbers.Length; j++)
                    {
                        sum += arrayNumbers[j];
                    }

                    Console.WriteLine($"\nРавна - {sum}");
                    Console.ReadKey();
                }
                else if (input == exitCommand)
                {
                    Console.WriteLine();
                    Console.WriteLine("Выход из программы.");
                    Console.ReadKey();
                    isWorking = false;
                }
                else
                {
                    int[] tempArrayNumbers = new int[arrayNumbers.Length + 1];

                    for (int i = 0; i < arrayNumbers.Length; i++)
                    {
                        tempArrayNumbers[i] = arrayNumbers[i];
                    }

                    tempArrayNumbers[arrayNumbers.Length] = int.Parse(input);
                    arrayNumbers = tempArrayNumbers;
                }
            }
        }
    }
}
