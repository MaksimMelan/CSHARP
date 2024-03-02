using System;

namespace _0004_SwappingValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Полное имя: ";
            string name= "Иванов ";
            string surname = "Иван ";
            string clipboardName;

            Console.WriteLine(fullName + name + surname);

            clipboardName = name;
            name = surname;
            surname = clipboardName;

            Console.WriteLine();
            Console.WriteLine(fullName + name + surname);

            Console.ReadKey();
        }
    }
}
