using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_015_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * WHILE -выполняет действие столько раз сколко нам нужно.
             */
            int count = 0;
            int limit = int.Parse(Console.ReadLine());

            while ( ++count <= limit )
            {
                Console.WriteLine( count );
            }
            Console.ReadKey();
        }
    }
}
