using System;
using System.Collections;
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
            const string CommandExit = "4";

            string finalExitMessage = "After pressing any button the program will close!";

            bool isWork = true;

            Dictionary<string, List<string>> positionStaff = new Dictionary<string, List<string>>()
            {
                ["Programmer"] = new List<string> { "Ivanov Ivan Ivanovich" },
                ["Designer"] = new List<string> { "Petrova Anna Sergeevna", "Smirnov Oleg Viktorovich" },
                ["QA"] = new List<string> { "Kozlov Dmitry Andreevich", "Morozova Elena Igorevna", "Sokolov Pavel Romanovich" },
                ["Manager"] = new List<string> { "Fedorova Maria Alekseevna" },
                ["System administrator"] = new List<string> { "Grigoriev Artyom Vasilievich", "Belova Tatyana Nikolaevna" },
                ["Analyst"] = new List<string> { "Zaitsev Nikolai Petrovich" }
            };

            while (isWork)
            {
                Console.Clear();
                Console.WriteLine($"{CommandAddDossier} - Add dossier.");
                Console.WriteLine($"{CommandDeleteDossier} - Delete dossier");
                Console.WriteLine($"{CommandOutputDossier} - Display all dossier.");
                Console.WriteLine($"{CommandExit} - Exit.");

                Console.WriteLine("Select an item: \n");
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
                    case CommandExit:
                        Console.WriteLine(finalExitMessage);
                        Console.ReadKey();
                        isWork = false;
                        break;
                }
            }
        }

        private static void AddDossier(Dictionary<string, List<string>> dictionary)
        {
            Console.WriteLine("Enter the employee's full name: \n");
            string nameStaff = Console.ReadLine();

            Console.WriteLine("Enter your position: ");
            string position = Console.ReadLine();

            if (!dictionary.ContainsKey(position))
            {
                dictionary.Add(position, new List<string>());
                Console.WriteLine($"Position - {position} add.");
            }

            dictionary[position].Add(nameStaff);
            Console.WriteLine($"\nEmployee - {nameStaff} added to position - {position}");
            Pause();
        }

        private static void DeleteDossier(Dictionary<string, List<string>> dictionary)
        {
            Console.WriteLine("Enter your position: ");
            OutputCollection(dictionary.Keys);
            Console.WriteLine();
            string userInput = Console.ReadLine();

            if(TryReadInt(userInput, out int userNumber) == false)
            {
                Console.WriteLine($"Invalid input.");
                Pause();
                return;
            }

            if(TryValidateNumberInRange(userNumber, dictionary.Count) == false)
            {
                Console.WriteLine("There is no such position.");
                Pause();
                return;
            }

            List<string> staffList = new List<string>();

            foreach (var staff in dictionary.Keys)
            {
                staffList.Add(staff);
            }

            string staffKey = staffList[userNumber - 1];

            List<string> fullNames = dictionary[staffKey];

            OutputCollection(fullNames);

            Console.WriteLine();
            Console.WriteLine("Enter the employee number to delete; \n");
            userInput = Console.ReadLine();

            if (TryReadInt(userInput, out int fullNamesNumber) == false)
            {
                Console.WriteLine($"Invalid input.");
                Pause();
                return;
            }

            if (TryValidateNumberInRange(fullNamesNumber, fullNames.Count) == false)
            {
                Console.WriteLine("There is no employee with this number");
                Pause();
                return;
            }

            int index = fullNamesNumber - 1;

            string deleteName = fullNames[index];
            fullNames.RemoveAt(index);
            Console.WriteLine($"Employee {fullNamesNumber} - {deleteName} removed from the list and from position {staffKey}.");

            if (dictionary[staffKey].Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"In position {staffKey} -  there are no more employees, this position is being deleted.");
                dictionary.Remove(staffKey);
            }

            Pause();
        }

        private static void OutputDossier(Dictionary<string, List<string>> dictionary)
        {
            Console.WriteLine("List of positions and employees: \n");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($" {string.Join(", ", item.Value)}");
            }

            Console.WriteLine();
            Pause();
        }

        static void Pause()
        {
            Console.WriteLine($"Press any key to continue.");
            Console.ReadKey();
        }

        static void OutputCollection(IEnumerable collection)
        {
            int i = 1;

            foreach (var item in collection)
            {
                Console.WriteLine($"{i++}. {item}");
            }
        }

        static bool TryReadInt(string input, out int number)
        {
            if (int.TryParse(input, out number) == false)
            {
                return false;
            }

            return true;
        }

        static bool TryValidateNumberInRange(int number, int maxCount )
        {
            if (number < 1 || number > maxCount)
            {               
                return false ;
            }

            return  true; 
        }
    }
}
