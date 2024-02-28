using System;

namespace S_0019_parenthesis_expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char fistSymbol = '(';
            char secondSymbol = ')';
            string userInput = "";
            int symbolsCount = 0;
            int symbolsMaxDepth = 0;
            bool hasBrackets =  false;

            Console.WriteLine("Программа позволит определить корректность и глубину строки:");
            userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == fistSymbol)
                {
                    symbolsCount++;
                    hasBrackets = true;

                    if (symbolsCount > symbolsMaxDepth)
                    {
                        symbolsMaxDepth = symbolsCount;
                    }
                }
                else if (userInput[i] == secondSymbol)
                {
                    symbolsCount--;

                    if (symbolsCount < 0)
                    {
                        break;
                    }
                }
            }

            if (symbolsCount != 0)
            {
                Console.WriteLine("Не корректная запись.");
            }
            else if (hasBrackets == false)
            {
                Console.WriteLine("В строке не было скобок");
            }
            else
            {
                Console.WriteLine($"Строка корректная. Максимальная глубина - {symbolsMaxDepth}.");
            }
            Console.ReadKey();
        }
    }
}
