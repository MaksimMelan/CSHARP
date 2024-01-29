using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_8_DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = 6, number2 = 7;
            double arithmeticMean = ( number1 + number2 ) / 2;

            Console.WriteLine("Среднее арифметическое чисел " + number1 + " и " + number2 + " равно " + arithmeticMean);
            Console.ReadKey();
        }
    }
}
