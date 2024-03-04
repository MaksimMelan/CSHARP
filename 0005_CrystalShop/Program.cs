using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0005_CrystalShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Сколько кристалов вы хотите купить?";
            string messagePriceСrystals = "Цена за  1 кристал - ";
            string messageCashGoldPlayer = "Золота у игрока - ";
            string messageCashCrystalsPlayer = "Кристаллов у игрока - ";
            string requestingBuyCrystals = "Сколько хотите купить? ";
            string messagePriceBuyCrystals = " - потрачено золота за купленные кристаллы!";

            int priceСrystals = 70;
            int cashGoldPlayer = 2500;
            int cashCrystalsPlayer = 0;
            int buyCrystals = 0;
            int priceBuyCrystals = 0;

            Console.WriteLine(greeting);
            Console.WriteLine();
            Console.WriteLine(messagePriceСrystals + priceСrystals);
            Console.WriteLine(messageCashGoldPlayer + cashGoldPlayer);
            Console.WriteLine();
            Console.WriteLine(requestingBuyCrystals);
            Console.WriteLine();

            buyCrystals = int.Parse(Console.ReadLine());

            priceBuyCrystals = buyCrystals * priceСrystals;
            cashGoldPlayer -= priceBuyCrystals;
            cashCrystalsPlayer += buyCrystals;

            Console.WriteLine();
            Console.WriteLine(messageCashGoldPlayer + cashGoldPlayer);
            Console.WriteLine(messageCashCrystalsPlayer + cashCrystalsPlayer);
            Console.WriteLine(priceBuyCrystals + messagePriceBuyCrystals);

            Console.ReadKey();
        }
    }
}
