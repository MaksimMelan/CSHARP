using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0011_Functions
{
    internal class Program
    {
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Привет!");
            Console.WriteLine("Ты здесь?");
            ConsoleColor defaultColor = Console.ForegroundColor;// в переменной defaultColor значение цвета шрифта в консоли. Мы его сохранили чтоб потом вернуть этот цвет шрифат в консоли обратно.
            Console.ForegroundColor = ConsoleColor.Red; // придаём Карсный цвет шрифту в консоли.
            Console.WriteLine("Нет соединения с интернетом");
            Console.ForegroundColor = defaultColor;
            Console.WriteLine("Странно...");
            Console.ReadKey();
            */
        /*
        static void Main(string[] args)
        {       
            Console.WriteLine("Привет!");
            Console.WriteLine("Ты здесь?");
            WriteError();
            Console.WriteLine("Странно...");
            Console.ReadKey();
            WriteError();

            Console.ReadKey();
        }

        static void WriteError()
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нет соединения с интернетом");
            Console.ForegroundColor = defaultColor;
        }
        */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Привет!");
            Console.WriteLine("Ты здесь?");
            WriteError("Нет соединения с интернетом");  //передаём текст в функцию      
            Console.WriteLine("Странно...");
            WriteError("Интернет не оплачен"); //передаём текст в функцию 

            Console.ReadKey();
        }
        static void WriteError(string text)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = defaultColor;
        }
        */
        /*
         * static void Main(string[] args)
        {
            int j = 3, y = 8, sum; // в данном случае `sum` не проиницилизиорованна (не задано значение)

            sum = Sum(j, y);

            sum = Sum(j, y) + j + y;//Console.WriteLine(sum);
            Console.WriteLine(sum);
            Console.WriteLine(Sum(2, 3));

            Console.ReadKey();
        }

        static int Sum(int x, int y)
        {
            int sum;
            sum = x + y;
            return sum; // || это можно записать так - `return x + y;`
        }
        */
        /*static void Main(string[] args)
        {
            Console.WriteLine("Привет!");
            Console.WriteLine("Ты здесь?");
            WriteError("Нет соединения с интернетом", ConsoleColor.Red);
            Console.WriteLine("Странно...");
            WriteError("Интернет не оплачен", ConsoleColor.Yellow);
            Console.ReadKey();
        }

        static void WriteError(string text, ConsoleColor color)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = defaultColor;
        }
        */
        /*
         static void Main(string[] args)
         {
            Console.WriteLine("Привет!");
            Console.WriteLine("Ты здесь?");
            WriteError("Нет соединения с интернетом", ConsoleColor.Green);
            Console.WriteLine("Странно...");
            WriteError("Интернет не оплачен");
            Console.ReadKey();
        }

        static void WriteError(string text, ConsoleColor color = ConsoleColor.Red)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = defaultColor;
        }
        */
        /*
         * static void Main(string[] args)
        {
            Console.WriteLine("Привет!");
            Console.WriteLine("Ты здесь?");
            WriteError("Нет соединения с интернетом", ConsoleColor.Green);
            Console.WriteLine("Странно...");
            WriteError("Интернет не оплачен");

            Console.ReadKey();
        }

        static void WriteError(string text, ConsoleColor color = ConsoleColor.Red, char symbol = '!' )
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(symbol + text);
            Console.ForegroundColor = defaultColor;
        }
        */
       
        static void Main(string[] args)
        {
            Console.WriteLine("Привет!");
            Console.WriteLine("Ты здесь?");
            WriteError("Нет соединения с интернетом", ConsoleColor.Green);
            Console.WriteLine("Странно...");
            WriteError("Интернет не оплачен", symbol: '@');
            Console.ReadKey();
        }

        static void WriteError(string text, ConsoleColor color = ConsoleColor.Red, char symbol = '!' )
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(symbol + text);
            Console.ForegroundColor = defaultColor;
        }      
    }
}

