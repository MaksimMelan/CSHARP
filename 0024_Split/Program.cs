using System;

namespace _0024_Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "Дана строка с текстом, используя метод строки String.Split() получить массив слов, которые разделены пробелом в тексте и вывести массив, каждое слово с новой строки. ";

            Char[] separators = new char[] { ' ', ',' };
            String[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].EndsWith("."))
                {
                    words[i] = words[i].Substring(0, words[i].Length - 1);
                }
            }

            Console.WriteLine($"Дана строка: {line}");
            Console.WriteLine("Подстроки:");

            foreach (string partOfWhole in words)
            {
                Console.WriteLine(partOfWhole);
            }
            Console.ReadKey();
        }
    }
}
