using System;

namespace _0008_Array_Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bag = new int[1];
            bag[0] = 12;
            int[] tempBag = new int[bag.Length + 1];

            for(int i = 0; i < bag.Length; i++)
            {
                tempBag[i] = bag[i];
                Console.WriteLine(bag[i] + " Первый ");

            }

            Console.WriteLine(
                );
            tempBag[tempBag.Length - 1] = 56;

            bag = tempBag;

            for (int i = 0;i < tempBag.Length; i++)
            {
                Console.WriteLine(bag[i] + " Второй ");
            }

            Console.ReadKey();
        }
    }
}
