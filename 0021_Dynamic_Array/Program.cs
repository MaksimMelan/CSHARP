using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0021_Dynamic_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] arrayNumbers = new int[1];
                int[] tempArrayNumbers = new int[arrayNumbers.Length +1];
                int sum = 0;

                string sumCommand = "sum";
                string input = "";
                string exitCommand = "exit";
                bool isWorking = true;

                while (isWorking)
                {
                    for (int i = 0; i < arrayNumbers.Length; i++)
                    {

                        Console.WriteLine($"Введите слово {sumCommand} для вывода суммы всех введённых чисел.\nВведите {exitCommand}  для выхода из программы. " +
                            $"\nМожете вводить числа для подсчёта суммы:");
                        Console.WriteLine();

                        input = Console.ReadLine();

                        if (input == exitCommand)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Выход из программы.");
                            Console.ReadKey();
                            isWorking = false;
                        }

                        else if (input == sumCommand)
                        {
                            for (int j = 0; j < arrayNumbers.Length; j++)
                            {
                                Console.Write(arrayNumbers[j]);
                                sum += arrayNumbers[j];
                            }

                            Console.WriteLine($"Сумма всех введённых чисел равна - {sum}");
                            Console.ReadKey();
                        }

                        arrayNumbers[i] = int.Parse(input);
                        tempArrayNumbers[i] = arrayNumbers[i];
                        arrayNumbers[i] = tempArrayNumbers[i];
                        Console.Clear();
                    }                  
                }
            }
        }
    }
}
