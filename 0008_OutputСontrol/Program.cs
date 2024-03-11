using System;

namespace _0008_OutputСontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string exitCommand = "exit";
            bool exit = false; 

            Console.WriteLine($"Введите слово 'exit'  для выхода из программы.");
            Console.WriteLine();

            while (exit == false)
            {
                input = Console.ReadLine();
                Console.WriteLine();

                if ( input == exitCommand ) 
                {
                    Console.WriteLine();
                    Console.WriteLine("Выход из программы.");
                    Console.ReadKey();
                    exit = true;
                }              
            }         
        }
    }
}
