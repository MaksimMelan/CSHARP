using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Операторы отношений ( любой оператор отношений возвращает Булевый результат).
             * Операторы сравнений
             */

            /*
                == Равно
                != Не равно
                >  Больше
                <  Меньше
                >= Больше или равно
                <= Меньше или равно
            */

            int a = 5; 
            
            int b = 4;


            Console.WriteLine( a == b); // выражение не истенно, значение - Folse.
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);

            bool result = a == b;

            Console.WriteLine( result );

            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);

            Console.ReadKey();
        }
    }
}
