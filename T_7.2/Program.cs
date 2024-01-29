using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "5.9jlkjfds";
            try
            {
                double a = double.Parse(str);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка при конвертации! Введите цифры");
            }

        }
    }
}
