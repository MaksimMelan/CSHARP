using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // помнить по приоритете постфиксног и префисного  инкримента.
            int a = 0;

            Console.WriteLine(a++); // выводит 0 а потом прибаляет 1.

            int b = 0;
            
            Console.WriteLine(++b); // выводит 1 - сначало прибавляет а потом выводит.

            int c = 1;

            c = ++c * c; // сколько будет? 

            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
