using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;

            int a, b;

            Console.WriteLine("Введите первое число 1");

            str = Console.ReadLine();

            a = Convert.ToInt32(str);

            Console.WriteLine("Ведите число 2");

            str = Console.ReadLine();

            b = Convert.ToInt32(str);

            int result = a + b;

            Console.WriteLine("Сумма чисел = " + result);

            Console.ReadKey();
        }
    }
}
