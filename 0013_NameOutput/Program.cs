using System;

namespace _0013_NameOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string messageInputName = "Введите имя:";
            string messageInputSymbol = "Введите символ:";
            string name = string.Empty;
            string frame = string.Empty;
            char symbol = '\0';

            Console.WriteLine(messageInputName);

            name = Console.ReadLine();

            Console.WriteLine(messageInputSymbol);

            symbol = (char)Console.Read();

            string middleLine = symbol + name + symbol;

            for (int i = 0; i < middleLine.Length; i++)
            {
                frame += symbol;
            }

            Console.Write($"\n{frame}\n{middleLine}\n{frame}");

            Console.ReadKey();
        }
    }
}
