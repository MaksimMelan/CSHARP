using System;

namespace _0008_OutputСontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            Console.WriteLine($"Введите слово 'exit'  для выхода из программы.");
            Console.WriteLine();

            while (input != "exit")
            {
                input = Console.ReadLine();
            }
            Console.WriteLine("Выход из программы.");
        }
    }
}
