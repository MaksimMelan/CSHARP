using System;
using System.Collections.Generic;

namespace _0038_HA_Advanced_personnel_accounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandAddDossier = "1";
            const string CommandDeleteDossier = "2";
            const string CommandOutputDossier = "3";
            const string CommandExite = "4";

            string finalExitMessage = "После нажатия любой кнопки программа закроется!";

            bool isWork = true;

            Dictionary<string, List<string>> positionStaff = new Dictionary<string, List<string>>()
            {
                ["Программист"] = new List<string> { "Иванов Иван Иванович" },
                ["Дизайнер"] = new List<string> { "Петрова Анна Сергеевна", "Смирнов Олег Викторович" },
                ["Тестировщик"] = new List<string> { "Козлов Дмитрий Андреевич", "Морозова Елена Игоревна", "Соколов Павел Романович" },
                ["Менеджер"] = new List<string> { "Фёдорова Мария Алексеевна" },
                ["Системный администратор"] = new List<string> { "Григорьев Артём Васильевич", "Белова Татьяна Николаевна" },
                ["Аналитик"] = new List<string> { "Зайцев Николай Петрович" }
            };

            while (isWork)
            {
                Console.Clear();
                Console.WriteLine($"{CommandAddDossier} - Добавить досье.");
                Console.WriteLine($"{CommandDeleteDossier} - Удалить досье");
                Console.WriteLine($"{CommandOutputDossier} - Вывести все досье.");
                Console.WriteLine($"{CommandExite} - Выход.");

                Console.WriteLine("Выберете пункт: \n");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case CommandAddDossier:
                        AddDossier(positionStaff);
                        break;
                    case CommandDeleteDossier:
                        DeleteDossier(positionStaff);
                        break;
                    case CommandOutputDossier:
                        OutputDossier(positionStaff);
                        break;
                    case CommandExite:
                        Console.WriteLine(finalExitMessage);
                        Console.ReadKey();
                        isWork = false;
                        break;
                }
            }
        }

        private static void AddDossier(Dictionary<string, List<string>> dictionary)
        {
            Console.WriteLine("Введите полное имя сотрудника: \n");
            string nameStaff = Console.ReadLine();

            Console.WriteLine("Введите должность: ");
            string position = Console.ReadLine();

            if (dictionary.ContainsKey(position))
            {
                dictionary[position].Add(nameStaff);
                Console.WriteLine($"\nСотрудник - {nameStaff} добавлен на должность - {position}");
                Console.WriteLine("\nДля продолжения нажмите любую клавишу");
            }
            else
            {
                dictionary.Add(position, new List<string>());
                dictionary[position].Add(nameStaff);
                Console.WriteLine($"Должность - {position} добавлена, сотрудник - {nameStaff} добавлен.");
            }
        }

        private static void DeleteDossier(Dictionary<string, List<string>> dictionary)
        {
            Console.WriteLine("Введите имя для удаления; \n");
            string nameStaff = Console.ReadLine();

            Console.WriteLine("Введите должность: ");
            string position = Console.ReadLine();

            if (!dictionary.ContainsKey(position))
            {
                Console.WriteLine("Такой должности не существует.");
                Console.WriteLine($"Нажмите любую клавишу для продолжения.");
                Console.ReadKey();
                return;
            }

            if (dictionary[position].Remove(nameStaff))
            {
                Console.WriteLine($"Сотрудник {nameStaff} удалён из списка и с должности {position}.");
            }
            else
            {
                Console.WriteLine($"Сотрудник {nameStaff} не найден.");
                Console.ReadKey();
                return;
            }

            if (dictionary[position].Count == 0)
            {
                Console.WriteLine($"На должности {position} больше нет сотрудников, эта должность удаляется.");
                Console.WriteLine($"Нажмите любую клавишу для продолжения.");
                dictionary.Remove(position);
            }

            Console.WriteLine($"Нажмите любую клавишу для продолжения.");
            Console.ReadKey();
        }

        private static void OutputDossier(Dictionary<string, List<string>> dictionary)
        {
            Console.WriteLine("Список должностей и сотрудников: \n");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($" {string.Join(", ", item.Value)}");
            }

            Console.WriteLine();
            Console.WriteLine($"Нажмите любую клавишу для продолжения.");
            Console.ReadKey();
        }
    }
}
