using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_022_NESTED_LOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* переменная i уже существует в этой облости видимости и она пернадлежит циклу выше по иерархии
            /* for (int i = 1; i <= 3; i++)
             * {
             *     Console.WriteLine("цикл 1 итерация №: " + i);
             *
             *     for (int j = 0; j <= 5; j++)
             *     {
             *         Console.WriteLine("\tцикл 2 итерация №: " + j);
             *
             *         for (int k = 1; k <= 2; k++)
             *         {
             *             Console.WriteLine("\t\tцикл 3 итерация №: " + k);
             *         }
             *     Console.ReadKey();
             *     }
             * }
             */

            /* прямоугольник
            Console.WriteLine("Введите высоту прямоугольника: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширину прямоугольника: ");
            int width = int.Parse(Console.ReadLine());

            for (int j = 0; j < height; j++)
            {
                for(int i = 0; i < width; i++)
                {
                Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */

            /* треугольники
             */
            int height = 15;

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int rows = 15;

            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
