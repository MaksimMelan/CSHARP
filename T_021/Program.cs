using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_021_CONTINUE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* CONTINUE повзоляет прервать какую-то итерацию
             * цикла, но не выходить из цикла.
             */
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
