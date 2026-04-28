using System;
using System.Collections.Generic;

namespace _0035_HA_Explanatory_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FindWordComand = "1";
            const string ExitComand = "2";

            Dictionary<string, string> countriesCapitals = new Dictionary<string, string>()
            {
                {"Россия", "Москва"},
                {"США", "Вашингтон"},
                {"Германия", "Берлин"},
                {"Япония", "Токио"}
            };

            bool isWork = true;

            while (isWork)
            {
                Console.Clear();

                ShowMenu(FindWordComand, ExitComand);

                string input = Console.ReadLine();

                if (input == ExitComand)
                {
                    Console.WriteLine("\nВы выбрали закрыть программу. \nНажмите любую клавишу");
                    isWork = false;

                }

                else if (input == FindWordComand)
                {
                    FindWord(countriesCapitals);
                }
                else
                {
                    Console.WriteLine("\nНеверная команда!");
                    continue;
                }

                Console.ReadKey();
            }
        }
        static void FindWord(Dictionary<string, string> dictionary)
        {
            Console.WriteLine("\nВведите страну");

            string input = Console.ReadLine();

            if (dictionary.ContainsKey(input))
            {
                Console.WriteLine($"\nСтолица страны {input} — {dictionary[input]}");

            }
            else
            {
                Console.WriteLine("\nТакой страны не существует");
            }
        }
        static void ShowMenu(string findCmd, string exitCmd)
        {
            Console.WriteLine();
            Console.WriteLine($"{findCmd} - поиск столицы.");
            Console.WriteLine($"{exitCmd} - выход из программы.");
        }

    }
}
