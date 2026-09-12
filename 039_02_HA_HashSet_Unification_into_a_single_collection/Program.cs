using System;
using System.Collections.Generic;

namespace _039_02_HA_HashSet_Unification_into_a_single_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> symbolsMerge = new HashSet<string>();
            string[] symbols1 = new string[] { "1", "2", "1" };
            string[] symbols2 = new string[] { "2", "3" };

            if (!CheckNullArray(symbols1)) return;
            if (!CheckNullArray(symbols2)) return;

            symbolsMerge = Merge(symbols1, symbols2);

            PrintList(symbolsMerge);
            Console.ReadKey();
        }

        private static void PrintList(HashSet<string> list)
        {
            Console.Write(string.Join(", ", list));
        }

        static HashSet<string> Merge(params string[][] arrays)
        {
            HashSet<string> result = new HashSet<string>();

            foreach (string[] array in arrays)
            {
                foreach (string s in array)
                {
                    result.Add(s);
                }
            }

            return result;
        }

        static bool CheckNullArray(string[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("Массив пуст, программа закрывается.");
                return false;
            }
            return true;
        }
    }
}
