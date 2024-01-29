using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

            /*
             * Конструкция if else
             */

            /*
                if - если( утверждение или выражение )
                {
                    действие 1;
                }
                else - иначе
                {
                    действие 2;
                }
            */

namespace T_013_If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*         
                bool isInfected = true;

                if (isInfected)
                {
                    Console.WriteLine("Персонаж инфицирован!");
                }
            */

            /*
                bool isInfected = false;

                if // - если // (isInfected)  
                {
                    Console.WriteLine("Персонаж инфицирован!");
                }
                else // - иначе
                {
                    Console.WriteLine("Персонаж здорорв");
                }
            */

            int a;
            
            a = int.Parse(Console.ReadLine());

            if ( a == 5)
            {
                Console.WriteLine("а равно 5");
            }
            else
            {
                Console.WriteLine("а не равно 5");
            }
            Console.ReadKey();
        }
    }
}
