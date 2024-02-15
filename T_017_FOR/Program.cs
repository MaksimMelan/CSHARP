using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_018_019_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* for (int i = 0; i < 10; i++)
             * //переменна i в цикле FOR  находится не в глобальной области видимости. её больше ни где не видно.
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            */

            /* int i = 0;

            for (; i < 3; i++)
            {
                Console.WriteLine("For_1: " + i);
            }
            for (; i < 5; i++)
            {
                Console.WriteLine("For_2: " + i);
            }
            Console.ReadKey();
            */

            /*for (int i = 0, j = 5; i < 10 && j < 12; i++, j++)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }
            Console.ReadKey();
            */

            /*for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            */

            /*for (int i = int.Parse(Console.ReadLine()); ; i > 0; i--)
             * такого лулчше избегать. но работать буедт.Лучше выносить..
             * но может понадобится не выносить i в область видимости из цикла.
             */
            /*int i = int.Parse(Console.ReadLine());

            for (; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            */

            /* цикл который считает одновренменно и вперёд и назад
            */
            for (int i = 0,j = 5; i < 5; i++, j--)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }
            Console.ReadKey();
        }
    }
}
