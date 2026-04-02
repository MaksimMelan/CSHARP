using System;
using System.Collections.Generic;

namespace _0032_L_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(22);
            numbers.Add(5);
            numbers.Add(6);

            numbers.AddRange(new int[] { 7, 8, 9, 10 });

            numbers.Insert(1, 0);
            numbers.Remove(6);
            numbers.RemoveAt(3);


            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);

            }

            Console.WriteLine(" Номер 22 находится в позиции " + (numbers.IndexOf(22) + 1));
            Console.ReadKey();
        }
    }
}
