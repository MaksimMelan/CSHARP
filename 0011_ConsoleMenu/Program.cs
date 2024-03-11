using System;

namespace _0011_ConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSetName = "1";
            const string CommandChangeConsoleColore = "2";
            const string InitialConsoleSettings = "3";
            const string CommandSetPassword = "4";
            const string CommandWriteName = "5";
            const string CommandEsc = "6";

            bool isWorking = true;

            string exitMessage = "Выход из программы! Нажмите любую клавишу!";
            string userInput;
            string nameUser = string.Empty;
            string invalidInput = string.Empty;
            string missingNameMessage = "Имя не установлено. Введите имя!";
            string messageNameReceived = "Имя получено! ";
            string passwordUser = string.Empty;
            string passwordReceived = "Пароль получен. ";
            string messagePasswordRequest = "Введите пароль";
            string missingPasswordUserMessage = "Пароль не установлен. Устновите пароль.";
            string invalidPasswordMessage = "Пароль не верный.";
            string noOption = "Такого варианта нет. ";
            string programMenu = $"Выберете действие:\n" +
                    $"{CommandSetName} - установите имя. \n" +
                    $"{CommandChangeConsoleColore} - именение цвета консоли - зелёный.\n" +
                    $"{InitialConsoleSettings} - начальные настройки консоли.\n" +
                    $"{CommandSetPassword} - установите пароль.\n" +
                    $"{CommandWriteName} - вывести имя после ввода пароля.\n" +
                    $"{CommandEsc} - выход из программы. ";

            Console.WriteLine(programMenu);

            while (isWorking)
            {
                Console.WriteLine();
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandSetName:
                        nameUser = Console.ReadLine();

                        if (userInput != invalidInput)
                        {
                            Console.WriteLine(messageNameReceived);
                        }
                        else
                        {
                            Console.WriteLine(missingNameMessage);
                        }
                        break;

                    case CommandChangeConsoleColore:
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;

                    case InitialConsoleSettings:
                        Console.ResetColor();
                        break;

                    case CommandSetPassword:
                        Console.WriteLine(messagePasswordRequest);
                        passwordUser = Console.ReadLine();
                        Console.WriteLine(passwordReceived);
                        break;

                    case CommandWriteName:
                        if (nameUser != invalidInput)
                        {
                            if (passwordUser != invalidInput)
                            {
                                Console.WriteLine(messagePasswordRequest);
                                userInput = Console.ReadLine();

                                if (userInput == passwordUser)
                                {
                                    Console.WriteLine(nameUser);
                                }
                                else
                                {
                                    Console.WriteLine(invalidPasswordMessage);
                                }
                            }
                            else
                            {
                                Console.WriteLine(missingPasswordUserMessage);
                            }
                        }
                        else
                        {
                            Console.WriteLine(missingNameMessage);
                        }
                        break;

                    case CommandEsc:
                        Console.WriteLine(exitMessage);
                        Console.ReadKey();
                        isWorking = false;
                        break;

                    default:
                        Console.WriteLine(noOption);
                        break;
                }
            }
        }
    }
}
