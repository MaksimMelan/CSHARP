using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_8_DZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, n3 = 0;

            Console.WriteLine("Введите первое число: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе числоо: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите первое число: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            // Ошибка заключается в том, что вы сначала присваиваете нули переменным n1, n2, n3,
            // а затем пытаетесь использовать их для вычисления amount и multiplication.
            // Вы должны вычислить amount и multiplication после ввода значений пользователем.
            // Вот исправленный код:
            int amount = n1 + n2 + n3;
            int multiplication = n1 * n2 * n3;

            Console.WriteLine("Сумма трех чисел " + n1 +", " + n2 + ", " + n3 + " равна - " + amount);
            Console.WriteLine("Произведение  трех чисел " + n1 + ", " + n2 + ", " + n3 + " равно - " + multiplication);
            Console.ReadKey();
        }
    }
}
