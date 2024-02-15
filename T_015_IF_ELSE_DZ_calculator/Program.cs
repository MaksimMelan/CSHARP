using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_015_IF_ELSE_DZ_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            string action;

            Console.WriteLine("Введите число 1: ");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2: ");
            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Выбирете операцию: '+' '-' '*' '/' ");
            action = Console.ReadLine();

            if (action == "+")
            {
                Console.WriteLine(firstValue + secondValue);
            }
            else if (action == "-")
            {
                Console.WriteLine(firstValue - secondValue);
            }
            else if (action == "*")
            {
                Console.WriteLine(firstValue * secondValue);
            }
            else if (action == "/")
            {
                if (secondValue == 0)
                    Console.WriteLine(0);// Если в блоке if только однастрочка кода, то можно без фигурных-{} скобок.
                else
                    Console.WriteLine(firstValue / secondValue);
            }
            else
            {
                Console.WriteLine("Ошибка! Неизвестное действие!");
            }
        }
    }
}
