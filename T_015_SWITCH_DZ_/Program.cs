using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_015_SWITCH_DZ_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                /*
           double firstNumber = 0;
           char operand = 'A';
           double secondNumber = 0;
           double result = 0;

           Console.WriteLine("Введите первое число: ");
           firstNumber = double.Parse(Console.ReadLine());

           Console.WriteLine("Введите оператор: ");
           operand = char.Parse(Console.ReadLine());

           Console.WriteLine("Введите второе число: ");
           secondNumber = double.Parse(Console.ReadLine());

           switch (operand)
           {
               case '-':
                   result = firstNumber - secondNumber;
                   Console.WriteLine("Результат: " + result);
                   break;

               case '+':
                   result = firstNumber + secondNumber;
                   Console.WriteLine("Результат: " + result);
                   break;
               case '/':

                   if (secondNumber == 0)
                   {
                       Console.WriteLine("На 0 делить нельзя!");
                       Console.ReadKey();
                       break;
                   }

                   result = firstNumber / secondNumber;
                   Console.WriteLine("Результат: " + result);
                   break;

               case '*':
                   result = firstNumber * secondNumber;
                   Console.WriteLine("Результат: " + result);
                   break;

               default:
                   Console.WriteLine("Я не знаю, что это за символ!");
                   break;
           */
                double firstValue, secondValue;
                string action;

                try
                {
                    Console.WriteLine("Введите число 1: ");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число 2: ");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch ( Exception )
                {
                    Console.WriteLine("Не коректный ввод! Введите цыфры.");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("Выбирете операцию: '+' '-' '*' '/' ");
                action = Console.ReadLine();



                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        /*
                        if (secondValue == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine(firstValue / secondValue);
                        }
                        break;
                        */
                        if (secondValue == 0)
                            Console.WriteLine(0);// Если в блоке if только однастрочка кода, то можно без фигурных-{} скобок.
                        else
                            Console.WriteLine(firstValue / secondValue);
                        break;
                    default:
                        Console.WriteLine("Ошибка! Неизвестное действие!");
                        break;
                }
            Console.ReadKey();
            }
        }        
    }
}
