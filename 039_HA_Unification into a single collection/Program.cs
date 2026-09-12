using System;
using System.Collections.Generic;

namespace _039_HA_Unification_into_a_single_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> symbolsMerge = new List<string>();
            string[] symbols1 = new string[] { "1", "2", "1" };
            string[] symbols2 = new string[] { "2", "3" };

            if (!CheckNullArray(symbols1)) return;
            if (!CheckNullArray(symbols2)) return;

            symbolsMerge = Merge(symbols1, symbols2);

            PrintList(symbolsMerge);
            Console.ReadKey();
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
