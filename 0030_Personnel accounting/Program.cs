using System;

namespace _0030_Personnel_accounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;

            const string CommandAddDossier = "1";
            const string CommandShowDossiers = "2";
            const string CommandDeletingDossier = "3";
            const string CommandSearchByLastName = "4";
            const string CommandExit = "5";

            string[] employeeNames = { "Борисова Анна Федоровна", "Борисов Семен Семенович", "Пилевин Виктор аркадьевич", "Борисов Василий Семеонвич", "Борисов Семеон Василивич", };
            string[] employeePost = { "Инженер", "Доктор", "Учитель", "Дерижёр", "Вахтёр" };

            while (isWork)
            {
                Console.WriteLine("Меню программы:");
                Console.WriteLine($"{CommandAddDossier}. добавить досье");
                Console.WriteLine($"{CommandShowDossiers}. выввести досье");
                Console.WriteLine($"{CommandDeletingDossier}. удалить досье");
                Console.WriteLine($"{CommandSearchByLastName}. поиск по фамилии");
                Console.WriteLine($"{CommandExit}. выход");

                Console.WriteLine();

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandAddDossier:
                        AddDossier(ref employeeNames, ref employeePost);
                        break;

                    case CommandShowDossiers:
                        ShowDossiers(employeeNames, employeePost);
                        Console.ReadKey();
                        break;

                    case CommandDeletingDossier:
                        DeletingDossier(ref employeeNames, ref employeePost);
                        Console.ReadKey();
                        break;

                    case CommandSearchByLastName:
                        SearchByLastName(ref employeeNames, ref employeePost);
                        Console.ReadKey();
                        break;

                    case CommandExit:
                        isWork = !isWork;
                        break;

                    default:
                        Console.WriteLine("Такого варианта нет!");
                        break;
                }

                Console.Clear();
            }

            Console.WriteLine("Вы вышли из программы!");
            Console.ReadKey();
        }

        public static void AddDossier(ref string[] employeeNames, ref string[] employeePost)
        {
            Console.WriteLine("Введите ФИО:");
            string userInput = Console.ReadLine();
            employeeNames = AddArrayElement(userInput, employeeNames);

            Console.WriteLine("Ввелдите должность:");
            userInput = Console.ReadLine();
            employeePost = AddArrayElement(userInput, employeePost);
        }

        public static string[] AddArrayElement(string inputString, string[] expandableArray)
        {
            string[] tempArray = new string[expandableArray.Length + 1];

            for (int i = 0; i < expandableArray.Length; i++)
            {
                tempArray[i] = expandableArray[i];
            }

            tempArray[tempArray.Length - 1] = inputString;

            return tempArray;
        }

        public static void ShowDossiers(string[] employeeNames, string[] employeePost)
        {
            Console.WriteLine();

            for (int i = 0; i < employeeNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {employeeNames[i]} - {employeePost[i]}");
            }
        }

        public static void DeletingDossier(ref string[] employeeNames, ref string[] employeePost)
        {
            ShowDossiers(employeeNames, employeePost);

            Console.WriteLine("Введите номер досье, которое хотите удалить: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int userLessIndexArray) && userLessIndexArray <= employeeNames.Length)
            {
                employeeNames = DeletingPosition(userLessIndexArray, employeeNames);
                employeePost = DeletingPosition(userLessIndexArray, employeePost);
            }
            else
            {
                Console.WriteLine("Такого досье не существует!");
            }

            Console.WriteLine();
            Console.WriteLine($"Список после удаления досье номер {userLessIndexArray}");

            ShowDossiers(employeeNames, employeePost);
        }

        public static string[] DeletingPosition(int userLessIndexArray, string[] massiv)
        {
            string[] tempMassiv = new string[massiv.Length - 1];

            for (int i = 0; i < userLessIndexArray - 1; i++)
            {
                tempMassiv[i] = massiv[i];
            }

            for (int i = userLessIndexArray; i < massiv.Length; i++)
            {
                tempMassiv[i - 1] = massiv[i];
            }

            massiv = tempMassiv;

            return massiv;
        }
        public static void SearchByLastName(ref string[] employeeNames, ref string[] employeePost)
        {
            bool foundLastName = false;

            Console.WriteLine("Введите фамилию:");

            string userInput = Console.ReadLine();

            Console.WriteLine("Вот список совпадений:");

            for (int i = 0; i < employeeNames.Length; i++)
            {
                string fullName = employeeNames[i];

                Char[] separators = new char[] { ' ', ',', '.' };
                string[] splitName = fullName.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < splitName.Length; j++)
                {
                    if (splitName[j] == userInput)
                    {
                        Console.WriteLine($"{i + 1}. {employeeNames[i]} - {employeePost[i]}");
                        foundLastName = true;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            if (foundLastName == false)
            {
                Console.WriteLine("Такой фамилии не существует!");
            }
        }
    }
}
