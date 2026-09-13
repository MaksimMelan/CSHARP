using System;
using System.Collections.Generic;

namespace _039_HA_Unification_into_a_single_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] symbols1 = new string[] { "1", "2", "1" };
            string[] symbols2 = new string[] { "2", "3" };

            if (IsNullOrEmptyArray(symbols1))
            {
                MessageIsNullOrEmptyArray();
                return;
            }
            if (IsNullOrEmptyArray(symbols2))
            {
                MessageIsNullOrEmptyArray();
                return;
            }

            List<string> symbolsMerge = Merge(symbols1, symbols2);

            PrintList(symbolsMerge);
            Console.ReadKey();
        }

        private static void MessageIsNullOrEmptyArray()
        {
            Console.WriteLine("Массив пуст, программа закрывается.");
        }

        private static void PrintList(List<string> list)
        {
            Console.Write(string.Join(", ", list));
        }

        static List<string> Merge(params string[][] arrays)
        {
            List<string> result = new List<string>();

            foreach (string[] array in arrays)
            {
                foreach (string s in array)
                {
                    if (!result.Contains(s))
                    {
                        result.Add(s);
                    }
                }
            }

            return result;
        }

        static bool IsNullOrEmptyArray(string[] arr)
        {
            return arr == null || arr.Length == 0;
        }
    }
}
