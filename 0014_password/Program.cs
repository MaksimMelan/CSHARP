using System;

namespace _0014_password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 3;
            string password = "54321";
            string userInput;

            for (int i = tryCount; i > 0 ; i--)
            {               
                Console.Write($"У Вас {i} попытки\n");
                Console.Write($"Введите пароль: "); ;
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine("Секретное слово: ПАРОЛЬ.");
                    Console.ReadKey();
                    break;
                }
            }
            
            Console.WriteLine("У Вас кончились попытки! Пока! ");
            Console.ReadKey();
        }
    }
}
