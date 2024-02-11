using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_014_logical_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                bool isInfected = true;
    
                if (!isInfected) // операто "не" - "!".
                {
                    Console.WriteLine("Персонаж здоров!");
                }
                else
                {
                    Console.WriteLine("Персонаж инфицирован!");
                }
            */

            int fanSpeed = 3000;

            bool isHighTemperature = false;

            bool hasNoCooling = fanSpeed <= 0;
            /*
             * 1) Выражение сравнение выдаёт значение bool.В данном случае выражение должно показывать, что в bool заносится или тру или фолс.
             * 2) Профессиональная привычка проверять значение меньше или = 0 ( может быть глюк и такое условие это страховка );
             */

            // && - и, || - или  сокращённые 
            /*
                if ( isHighTemperature || hasNoCooling ) // && - и, || - или 
                {
                    Console.WriteLine("Угроза повреждения процессора");
                }
                else
                {
                    Console.WriteLine("Угрозы  процессору нет!");
                }
                Console.ReadKey();
            */

            // & - и, | - или  -- НЕ СОКРАЩЁННЫЕ!
            // Есил && то проверяется только первая часть выраженияи если она фолс, то вторая не проверяется.
            // Если  &, - то работать код тоже будет, но будет работать медленней, так как проверяет ещё и вторую чать.
            // Если | - так же смотрит обе части. 
            if (isHighTemperature || hasNoCooling) 
            {
                Console.WriteLine("Угроза повреждения процессора");
            }
            else
            {
                Console.WriteLine("Угрозы  процессору нет!");
            }
            Console.ReadKey();


        }
    }
}
