using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003_One_dimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] cucumbers = new int[10]; // у нас массив из десяти пустых банок.
            //Console.WriteLine(cucumber[0]); // обращаемся к первой банке под номером 0 и спрашиваем что у неё внутри
            //Console.WriteLine($"{cucumber.Length}\n");//выводим в консоль длинну массива

            //cucumber[7] = 13; // обращаемся к определённому элементу массива и присваеваем ему значение
            //cucumber[3] = 3;

            int[] cucumbers = { 24, 25, 17, 38, 100, int.MaxValue, int.MinValue};
            int[] cucumbers2 = new int[4] { 4, 1, 6, 7 };

            for (int i = 0; i < cucumbers.Length; i++) // обращаемся к массиву и узанём его длинну
            {                    
                Console.Write(cucumbers[i] + " ");           
            }

            Console.WriteLine();

            for (int i = 0;i < cucumbers2.Length; i++)
            {
                Console.Write(cucumbers2[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
