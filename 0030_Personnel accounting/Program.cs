using System;

namespace _0030_Personnel_accounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;

            string[] employeeNames = { "Борисова Анна Федоровна", "Борисов Семен Семенович", "Пилевин Виктор аркадьевич", "Борисов Василий Семеонвич", "Борисов Семеон Василивич", };
            string[] employeePost = { "Инженер", "Доктор", "Учитель", "Дерижёр", "Вахтёр" };
            while (isWork)
            {
                Console.WriteLine("Меню программы:");          
                Console.WriteLine("1)добавить досье");        
                Console.WriteLine("2)выввести досье");
                Console.WriteLine("3)удалить досье");
                Console.WriteLine("4)поиск по фамилии");
                Console.WriteLine("5)выход");
                Console.WriteLine();
                string userInput = Console.ReadLine();
                
                if (int.TryParse(userInput, out int number))
                {
                    switch (number)
                    {
                        case 1: //1)добавить досье,
                            AddDossier(ref employeeNames, ref employeePost);
                            break;

                        case 2: //2)выввести досье (в одну строчку через "-"ФИО и должность с порядковым номером в начале),
                            ShowDossier(employeeNames, employeePost);
                            Console.ReadKey();
                            break;

                        case 3: 
                            DeletingDossier(ref employeeNames, ref employeePost);
                            Console.ReadKey();
                            break;

                        case 4: //4)поиск по фамилии ( показ всех с данной фамилией )
                            SearchByLastName(ref employeeNames, ref employeePost);
                            Console.ReadKey();
                            break;

                        case 5://5)выход
                            isWork = !isWork;
                            break;

                        default:
                            Console.WriteLine("Такого варианта нет!");
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Не верный ввод!");
                    Console.ReadKey();
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
            employeeNames = AddingArrayElement(userInput, employeeNames);

            Console.WriteLine("Ввелдите должность:");
            userInput = Console.ReadLine();
            employeePost = AddingArrayElement(userInput, employeePost);
        }
           
        public static string[] AddingArrayElement(string inputString, string[] expandableArray)
        {
            string[] newArray = new string[expandableArray.Length + 1];

            for (int i = 0; i < expandableArray.Length; i++)
            {
                newArray[i] = expandableArray[i];
            }

            newArray[newArray.Length - 1] = inputString;


            return newArray;
        }

        public static void ShowDossier(string[] employeeNames, string[] employeePost)
        {
            Console.WriteLine();

            for (int i = 0; i < employeeNames.Length; i++)
            {
                Console.WriteLine($"{i+1}. {employeeNames[i]} - {employeePost[i]}");
            }    
        }

        public static void DeletingDossier (ref string[] employeeNames, ref string[] employeePost)
        {
            string[] tempEmployeeNames = new string[employeeNames.Length -1 ];
            string[] tempEmployeePost = new string[employeePost.Length - 1];

            ShowDossier(employeeNames, employeePost);

            Console.WriteLine("Введите номер досье, которое хотите удалить: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int userLessIndexArray))
            {
                for (int i = 0; i < userLessIndexArray - 1; i++)
                {
                    tempEmployeeNames[i] = employeeNames[i];
                    tempEmployeePost[i] = employeePost[i];
                }

                for (int i = userLessIndexArray; i < employeePost.Length; i++)  
                {
                    tempEmployeeNames[i - 1] = employeeNames[i];
                    tempEmployeePost[i - 1] = employeePost[i];
                }
            }

            employeeNames = tempEmployeeNames;
            employeePost = tempEmployeePost;

            Console.WriteLine();
            Console.WriteLine($"Список после удаления досье номер {userLessIndexArray}");

            ShowDossier(employeeNames, employeePost);
        }

        public static void SearchByLastName (ref string[] employeeNames, ref string[] employeePost)
        {
              
            Console.WriteLine("Введите фамилию:");

            string userInput = Console.ReadLine();

            Console.WriteLine("Вот список совпадений:");

            for (int i = 0;i < employeeNames.Length; i++)
            {
                string fullName = employeeNames[i];

                Char[] separators = new char[] { ' ', ',', '.' };
                string[] splitName = fullName.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < splitName.Length; j++)
                {
                    if (splitName[j] == userInput)
                    {
                        Console.WriteLine($"{i + 1}. {employeeNames[i]} - {employeePost[i]}");
                    }
                    else
                    {
                        continue;
                    }
                }               
            }
        }
    }
}
