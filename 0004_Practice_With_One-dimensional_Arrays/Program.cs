using System;
using System.Runtime.InteropServices;

namespace _0004_Practice_With_One_dimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* определение суммы чисел массива
            int[] array = { 1, 2, 3, 4, 7, 8 };
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                Console.WriteLine(sum);
            }

            Console.WriteLine(sum);
            Console.ReadKey();
            */

            /*определение масимальнойго элемента массива
            int[] array = { 1, 2, 3, 5, 8, 12, 2, 25};
            int maxElement = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (maxElement < array[i])
                {
                    maxElement = array[i];
                }

            }
            Console.WriteLine(maxElement);
            Console.ReadKey();
            */

            // регистация пасажиров самолёта
            int[] sektors = { 6, 28, 15, 15, 17 };
            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 18);

                for (int i = 0; i < sektors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i + 1} свободно {sektors[i]} мест");
                }

                Console.SetCursorPosition(0, 00);
                Console.WriteLine("Регистрация рейса. ");
                Console.WriteLine("\n \n1 - Забронировать места \n2 - выход из программы.\n");
                Console.WriteLine("Введите номер команды: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaceAmount;
                        Console.WriteLine("В каком секторе вы хотите лететь? ");
                        userSector = Convert.ToInt32(Console.ReadLine()) -1;

                        if (sektors.Length < userSector || userSector < 0)
                        {
                            Console.WriteLine("Такого сектора не существует. ");
                            break;
                        }
                        Console.WriteLine("Сколько мест вы хотитие забронировать? ");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());

                        if (sektors[userSector] < userPlaceAmount || userPlaceAmount < 0)
                        {
                            Console.WriteLine($"В секотре {userSector} недостваточно мест. " +
                                $"Остаток {sektors[userSector]}");
                            break;
                        }

                        sektors[userSector] -= userPlaceAmount;
                        break;

                    case 2:
                        isOpen = false;
                        break;

                    default:
                        break;
                }
               
                Console.Clear();
            }
        }
    }
}
