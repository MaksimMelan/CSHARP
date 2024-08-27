using System;
using System.IO;

namespace _0015_Pac_Man
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] map = ReadMap("map.txt");
            DrawMap(map);
            Console.ReadKey();
        }

        private static char[,] ReadMap(string path)
        {
            string[] file = File.ReadAllLines("map.txt");

            char[,] map = new char[GetMaxLenthOfLine(file), file.Length];// 28, 11 ( а в фале показано 11, 28)

            for (int x = 0; x < map.GetLength(0); x++)  //file[0][0]
                for (int y = 0; y < map.GetLength(1); y++)
                    map[x, y] = file[y][x];

            return map;
        }

        private static void DrawMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {

                for (int x = 0; x < map.GetLength(0); x++)
                {
                    Console.Write(map[x, y]);
                }

                Console.Write("\n");
            }

        }

        private static int GetMaxLenthOfLine(string[] lines)
        {
            int maxLength = lines[0].Length;

            foreach (var line in lines)
                if(line.Length > maxLength)
                    maxLength = line.Length;

            return maxLength;
        }
    }
}
