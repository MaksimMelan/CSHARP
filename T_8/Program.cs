using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ОПЕРАТОРЫ
 * 
 * Арифметические операции с числами
 */

namespace T_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;

            //double result = (double)a / b; - так тоже можно.
            //int result = a % b; - остаток от деления.
            int result = a % b; // оператор присваевания (=) имеет меньший приоритет чем другие операции

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
