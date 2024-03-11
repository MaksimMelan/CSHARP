using System;

namespace _0008_OutputСontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string exitCommand = "exit";
            bool isWorking = true; 

            Console.WriteLine($"Введите слово {exitCommand}  для выхода из программы.");
            Console.WriteLine();

            while (isWorking)
            {
                input = Console.ReadLine();
                Console.WriteLine();

                if ( input == exitCommand ) 
                {
                    Console.WriteLine();
                    Console.WriteLine("Выход из программы.");
                    Console.ReadKey();
                    isWorking = false;
                }              
            }         
        }
    }
}
