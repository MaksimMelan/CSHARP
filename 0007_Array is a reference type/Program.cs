using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0007_Array_is_a_reference_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] array = new int[3];
            int[] tempArray  = new int[5];

            array = tempArray;

            array[0] = 5;

            Console.WriteLine(tempArray[0]);
            */
            int[] petrovich = new int[3];
            int[] ivanovich = new int[5];
            int[] sidorovich;

            petrovich = ivanovich;

            petrovich[0] = 5;
            petrovich[1] = 3;

            sidorovich = petrovich;

            sidorovich[2] = 5;
            sidorovich[0] = 10;

            Console.WriteLine(ivanovich[0]);
            Console.WriteLine(ivanovich[1]);

            petrovich = new int[10];

        }
    }
}
