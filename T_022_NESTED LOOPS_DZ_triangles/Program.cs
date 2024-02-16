using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_022_NESTED_LOOPS_DZ_triangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int height = 0;

            Console.WriteLine("Введите число: ");
            height = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */

            /*
            Console.WriteLine("Введите высоту треугольника: ");
            int height = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */

            int height = 0;

            Console.WriteLine("Введите число: ");
            height = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }  
                
                for ( int j = height; j > i; j-- )
                {
                    Console.Write('#');
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
