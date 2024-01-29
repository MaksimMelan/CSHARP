using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_013_If_else_DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;
            double remains;

            Console.WriteLine("Введите число:");
            number = Convert.ToDouble(Console.ReadLine());

            remains = number % 2;

            if ( remains == 0)
            {
                Console.WriteLine("Число " + number + " чётное!");
            }
            else
            {
                Console.WriteLine("Число " + number + " не чётное!");
            }
                Console.ReadKey();
        }
    }
}
