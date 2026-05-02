using System;
using System.Collections.Generic;

namespace _0036_HA_Queue_at_the_store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            int CalculateTotal = 0;

            Queue<int> productPriceQueue = new Queue<int>();

            AddPricesToQueue(productPriceQueue);

            CalculateTotal = ProcessPayment(productPriceQueue);

            Console.WriteLine($"Сумма: { CalculateTotal}");

            Console.WriteLine("Для выхода из программы нажмите любую клавишу");

            Console.ReadKey();
        }

        static void AddPricesToQueue(Queue<int> productPriceQueue)
        {
            string userInput;
            bool isAdding = true;

            while (isAdding)
            {
                Console.WriteLine("Введите цену товара. \nДля завершения ввода нажмите Enter.");


                foreach (int count in productPriceQueue)
                {
                    Console.WriteLine(count);
                }

                userInput = Console.ReadLine();

                if(userInput == string.Empty)
                {
                    isAdding = false;
                    continue;
                }

                if (!int.TryParse(userInput, out int price))
                {
                    Console.WriteLine("Ввод не верен.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                productPriceQueue.Enqueue(price);
                Console.WriteLine($"Товар с ценой {price} добавлен в очередь");

                Console.Clear();
            }
        }

        static int ProcessPayment(Queue<int> productPriceQueue )
        {
            int CalculateTotal = 0;

            while (productPriceQueue.Count > 0)
            {
                if (productPriceQueue.Count == 0)
                {
                    Console.WriteLine("Очередь пуста. Нет товаров для оплаты.");
                    continue;
                }
                else
                {
                    int price = productPriceQueue.Dequeue();
                    Console.WriteLine($"Оплачивается товар с ценой {price}");

                    CalculateTotal += price;
                    Console.WriteLine($"Сумма в кассе:  {CalculateTotal}");
                    Console.WriteLine("Нажмите любую клавишу.");

                    Console.ReadKey();
                    Console.Clear();
                }
            }

            return  CalculateTotal;
        }
    }
}
