using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_015_WHILE_DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            double range1, range2;
            double even = 0, notEven = 0;
            

            Console.WriteLine("Введите первое число диапазона: ");
            range1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число диапазона: ");
            range2 = double.Parse(Console.ReadLine());

            while (range1 <= range2)
            {
                double temp = range1++ % 2;
                bool result = temp == 0;

                if (result)
                {
                    even++;
                    Console.WriteLine("Чёт: " + even);
                }
                else
                {
                    notEven++;
                    Console.WriteLine("Не чёт: " +  notEven);
                }
            }
            Console.ReadKey();
            */

            uint addNumdersCount = 0; // нечётные  числа
            uint evenNumbersCount = 0; // чётные числа

            int oddNumbersSum = 0;
            int evenNumbersSum = 0;

            Console.WriteLine("Введите первое число диапазона: ");
            int currentVale = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число диапазона: ");
            int limit = int.Parse(Console.ReadLine());

            while (currentVale <= limit)
            {
                if (currentVale % 2 == 0)
                {
                    oddNumbersSum += currentVale;
                    evenNumbersCount++;
                }
                else
                {
                    evenNumbersSum += currentVale;
                    addNumdersCount++;
                }
                currentVale++;
            }

            Console.WriteLine("нечётные  числа: " + addNumdersCount);
            Console.WriteLine("чётные числа: " + evenNumbersCount);
            Console.WriteLine("Сумма нечётныхчисле: " + oddNumbersSum);
            Console.WriteLine("Сумма чётныхчисле: " + evenNumbersSum);
            Console.ReadKey();

        }
    }
}
