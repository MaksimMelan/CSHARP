using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_8_DZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount = 0;
            double rate = 0;
            double result = 0;

            Console.WriteLine("Введите сумму для конвертации: ");
            amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ведите текущий курс валюты: ");
            rate = Convert.ToDouble(Console.ReadLine());

            result = amount * rate;

            Console.WriteLine("Результат конвертации: " + result);
            Console.ReadKey();
        }

    }
}
