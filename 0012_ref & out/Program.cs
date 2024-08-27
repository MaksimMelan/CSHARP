using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0012_ref___out
{
    internal class Program
    {
        /*
        static void Main(string[] args)
        {
            int sum = 0, x = 1, y = 5;
            Add(sum, x, y);

            Console.WriteLine(sum);
        }

        static void Add(int sum, int x, int y)
        {
            sum = x + y;
        }
        */

        /*
        static void Main(string[] args)
        {
            int sum = 0, x = 1, y = 5;
            Add(ref sum, x, y);

            Console.WriteLine(sum);
            Console.ReadKey();
        }

        static void Add(ref int sum, int x, int y)
        {
            sum = x + y;
        }
        */


        /*
        static void Main(string[] args)
        {
            int sum = 0, x = 1, y = 5;
            Add(out sum, x, y);

            Console.WriteLine(sum);
            Console.ReadKey();
        }

        static void Add(out int sum, int x, int y)
        {
            sum = x + y;
        }
        */

        /*
        static void Main(string[] args)
        {
            int[] array = new int[5];
            EditArray(array, 2, 5);
            Console.WriteLine(array[2]);
            Console.ReadKey();
        }

        static void EditArray(int[] array, int index, int value)
        {
            array[index] = value;
        }
        */

        static void Main(string[] args)
        {
            int[] array = new int[5];
            array = EditArray(array, 2, 5);
            Console.WriteLine(array[2]);

            Console.ReadKey();
        }

        static int[] EditArray(int[] array, int index, int value)
        {
            array = new int[6];
            array[index] = value;
            return array;
        }
    }
}
